using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DONGHODEOTAY.Doituong;

namespace DONGHODEOTAY
{
    public partial class frmBanHang : Form
    {
        private Nguoidung nguoidung;

        public frmBanHang(Nguoidung nguoidung)
        {
            InitializeComponent();
            kn = new ketnoi();
            this.nguoidung = nguoidung;
            currentCustomer = new KhachHang();

            
        }
        

        ketnoi kn = new ketnoi();
        List<SanPham> danhSachSanPham = new List<SanPham>();
        private KhachHang currentCustomer;

       
        public void SetCustomerInfo(KhachHang kh)
        {
            currentCustomer = kh;

            txttenkh.Text = kh.Tenkh;
            txtsodt.Text = kh.Sodt;
            txtdiachi.Text = kh.Diachi;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            string maSanPham = txtma.SelectedValue.ToString();
            string tenSanPham = txtten.Text;
            int soLuong = (int)txtsoluong.Value;
            decimal donGia = decimal.Parse(txtgia.Text);
            var sanPham = danhSachSanPham.FirstOrDefault(sp => sp.Masp == txtma.SelectedValue.ToString());
            // Kiểm tra số lượng
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0 để thêm sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (soLuong > sanPham.Soluong)
            {
                MessageBox.Show($"Số lượng yêu cầu ({soLuong}) vượt quá số lượng tồn trong kho ({sanPham.Soluong}).",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong DataGridView chưa
            foreach (DataGridViewRow row in hienthihoadon.Rows)
            {
                if (row.Cells["Column1"].Value != null && row.Cells["Column1"].Value.ToString() == maSanPham)
                {
                    // Nếu đã tồn tại, cập nhật số lượng
                    row.Cells["Column3"].Value = soLuong;
                    row.Cells["Column5"].Value = donGia * soLuong; // Cập nhật thành tiền
                    TinhTongTien(); // Tính lại tổng tiền
                    return;
                }
            }

            // Nếu sản phẩm chưa tồn tại, thêm mới
            hienthihoadon.Rows.Add(maSanPham, tenSanPham, soLuong, donGia, donGia * soLuong);
            ClearTextBoxes();
            // Cập nhật tổng tiền
            TinhTongTien();


        }
        private void ClearTextBoxes()
        {
            txtsoluong.Value = 0;
            txtma.SelectedIndex = -1;
            txtten.SelectedIndex = -1;
            txtgia.Clear();
            

        }
        private void ClearTextBoxes1()
        {
            txttenkh.Clear();
            txtdiachi.Clear();
            txtsodt.Clear();
            txtthanhtoan.Clear();
            txttongtien.Clear();
            txtgiamgia.Clear();
        }
        private void TinhTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in hienthihoadon.Rows)
            {
                if (row.Cells["Column5"].Value != null)
                {
                    // Cộng giá trị từ cột Thành tiền
                    tongTien += Convert.ToDecimal(row.Cells["Column5"].Value);
                }
            }

            // Hiển thị tổng tiền lên txtTongTien
            txttongtien.Text = tongTien.ToString("N0"); // Định dạng số
        }
        private void LoadDataToComboBox()
        {
            // Câu truy vấn
            string query = "SELECT Masp, Tensp, Giaban ,Soluong FROM SanPham";

            try
            {
                // Mở kết nối nếu chưa mở
                if (kn.Connection.State != ConnectionState.Open)
                {
                    kn.Connection.Open();
                }

                // Thực hiện truy vấn và đọc dữ liệu
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    danhSachSanPham.Clear();

                    while (reader.Read())
                    {
                        danhSachSanPham.Add(new SanPham
                        {
                            Masp = reader["Masp"].ToString(),
                            Tensp = reader["Tensp"].ToString(),
                            Gia = Convert.ToDecimal(reader["Giaban"]),
                            Soluong = Convert.ToInt32(reader["Soluong"])
                        });
                    }
                    reader.Close();
                }

                // Gắn dữ liệu vào ComboBox txtma
                txtma.DataSource = danhSachSanPham;
                txtma.DisplayMember = "Masp";
                txtma.ValueMember = "Masp";

                // Gắn dữ liệu vào ComboBox txtten
                txtten.DataSource = danhSachSanPham;
                txtten.DisplayMember = "Tensp";
                txtten.ValueMember = "Masp";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void frmBanHang_Load(object sender, EventArgs e)
        {


            LoadDataToComboBox();
            txtsoluong.Value = 0;
            txtma.SelectedIndex = -1;
            txtten.SelectedIndex = -1;
            txtma.SelectedIndexChanged += txtma_SelectedIndexChanged;
            txtten.SelectedIndexChanged += txtten_SelectedIndexChanged;
        }

        private void txtma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtma.SelectedValue != null)
            {
                // Lấy sản phẩm được chọn
                var sanPham = danhSachSanPham.FirstOrDefault(sp => sp.Masp == txtma.SelectedValue.ToString());
                if (sanPham != null)
                {
                    txtten.SelectedValue = sanPham.Masp;
                    txtgia.Text = sanPham.Gia.ToString("N0"); // Hiển thị đơn giá định dạng số
                }
            }
        }

        private void txtten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtten.SelectedValue != null)
            {
                // Lấy sản phẩm được chọn
                var sanPham = danhSachSanPham.FirstOrDefault(sp => sp.Masp == txtten.SelectedValue.ToString());
                if (sanPham != null)
                {
                    txtma.SelectedValue = sanPham.Masp;
                    txtgia.Text = sanPham.Gia.ToString("N0");
                }
            }
        }


        /*private void CapNhatSoLuongSanPham(string maSanPham, int soLuong)
        {
            try
            {
                if (kn.Connection.State != ConnectionState.Open)
                    kn.Connection.Open();

                string query = "UPDATE SanPham SET Soluong = @Soluong WHERE Masp = @Masp";
                SqlCommand command = new SqlCommand(query, kn.Connection);

                command.Parameters.AddWithValue("@Soluong", soLuong);
                command.Parameters.AddWithValue("@Masp", maSanPham);

                command.ExecuteNonQuery();

                kn.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }*/
        private void hienthihoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hienthihoadon.Rows[e.RowIndex];
                txtma.Text = row.Cells["Column1"].Value.ToString();
                txtten.Text = row.Cells["Column2"].Value.ToString();
                txtsoluong.Text = row.Cells["Column3"].Value.ToString();
                txtgia.Text = row.Cells["Column4"].Value.ToString();
            }
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maSanPham = txtma.Text;
                string tenSanPham = txtten.Text;
                int soLuong = int.Parse(txtsoluong.Text);
                decimal donGia = decimal.Parse(txtgia.Text);

                if (soLuong == 0)
                {
                    // Xóa sản phẩm ra khỏi DataGridView nếu số lượng về 0
                    foreach (DataGridViewRow row in hienthihoadon.Rows)
                    {
                        if (row.Cells["Column1"].Value.ToString() == maSanPham)
                        {
                            hienthihoadon.Rows.RemoveAt(row.Index);

                            // Cập nhật số lượng trong cơ sở dữ liệu
                            //CapNhatSoLuongSanPham(maSanPham, soLuong);
                            TinhTongTien();
                            //MessageBox.Show($"Sản phẩm {maSanPham} đã được xóa khỏi danh sách.");
                            return;
                        }
                    }
                }
                else
                {
                    // Cập nhật số lượng mới vào DataGridView
                    foreach (DataGridViewRow row in hienthihoadon.Rows)
                    {
                        if (row.Cells["Column1"].Value.ToString() == maSanPham)
                        {
                            row.Cells["Column3"].Value = soLuong;
                            row.Cells["Column4"].Value = donGia;
                            TinhTongTien();
                            //CapNhatSoLuongSanPham(maSanPham, soLuong);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}");
            }
        }

        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (kn.Connection.State != ConnectionState.Open)
                    kn.Connection.Open();

                // Kiểm tra danh sách sản phẩm
                if (hienthihoadon.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin khách hàng
                string tenkh = txttenkh.Text.Trim();
                string sodt = txtsodt.Text.Trim();
                string diachi = txtdiachi.Text.Trim();
                decimal giamgia, tienban, thanhtoan;

                if (!decimal.TryParse(txtgiamgia.Text.Trim(), out giamgia))
                    giamgia = 0;

                if (!decimal.TryParse(txttongtien.Text.Trim(), out tienban))
                    tienban = 0;

                if (!decimal.TryParse(txtthanhtoan.Text.Trim(), out thanhtoan))
                    thanhtoan = 0;

                if (string.IsNullOrEmpty(tenkh) || string.IsNullOrEmpty(sodt) || string.IsNullOrEmpty(diachi))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int manv = nguoidung.Manv;

                // 1. Xác minh Mã nhân viên (Manv)
                string queryCheckManv = "SELECT COUNT(*) FROM NhanVien WHERE Manv = @Manv";
                SqlCommand cmdCheckManv = new SqlCommand(queryCheckManv, kn.Connection);
                cmdCheckManv.Parameters.AddWithValue("@Manv", manv);

                int countManv = (int)cmdCheckManv.ExecuteScalar();
                if (countManv == 0)
                {
                    MessageBox.Show("Nhân viên không hợp lệ hoặc không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Lấy Mã khách hàng (Makh)
                string queryMakh = "SELECT Makh FROM KhachHang WHERE Tenkh = @TenKhachHang";
                SqlCommand cmdMakh = new SqlCommand(queryMakh, kn.Connection);
                cmdMakh.Parameters.AddWithValue("@TenKhachHang", tenkh);

                object resultMakh = cmdMakh.ExecuteScalar();
                if (resultMakh == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int makh = Convert.ToInt32(resultMakh);

                TinhTongTien();

                // 3. Thêm hóa đơn vào bảng HoaDon
                string queryHoaDon = @"
    INSERT INTO HoaDon (Ngaytao, Manv, Makh, Tienban, Giamgia, Thanhtoan)
    VALUES (@Ngaytao, @Manv, @Makh, @Tienban, @Giamgia, @Thanhtoan);
    SELECT SCOPE_IDENTITY();";

                SqlCommand cmdHoaDon = new SqlCommand(queryHoaDon, kn.Connection);
                cmdHoaDon.Parameters.AddWithValue("@Ngaytao", DateTime.Now);
                cmdHoaDon.Parameters.AddWithValue("@Manv", manv);
                cmdHoaDon.Parameters.AddWithValue("@Makh", makh);
                cmdHoaDon.Parameters.AddWithValue("@Tienban", tienban);
                cmdHoaDon.Parameters.AddWithValue("@Thanhtoan", thanhtoan);
                cmdHoaDon.Parameters.AddWithValue("@Giamgia", giamgia);

                int mahd = Convert.ToInt32(cmdHoaDon.ExecuteScalar());

                // 4. Cập nhật chi tiết hóa đơn vào bảng CTHoaDon
                string queryCTHoaDon = @"
    IF EXISTS (SELECT * FROM CTHoaDon WHERE Mahd = @Mahd AND Masp = @Masp)
    BEGIN
        UPDATE CTHoaDon
        SET Soluong = Soluong + @Soluong, Dongia = @Dongia
        WHERE Mahd = @Mahd AND Masp = @Masp;
    END
    ELSE
    BEGIN
        INSERT INTO CTHoaDon (Mahd, Masp, Soluong, Dongia)
        VALUES (@Mahd, @Masp, @Soluong, @Dongia);
    END";

                foreach (DataGridViewRow row in hienthihoadon.Rows)
                {
                    if (row.Cells["Column1"].Value != null)
                    {
                        int masp = Convert.ToInt32(row.Cells["Column1"].Value);
                        int soluong = Convert.ToInt32(row.Cells["Column3"].Value);
                        decimal dongia = Convert.ToDecimal(row.Cells["Column4"].Value);

                        SqlCommand cmdCTHoaDonUpdate = new SqlCommand(queryCTHoaDon, kn.Connection);
                        cmdCTHoaDonUpdate.Parameters.AddWithValue("@Mahd", mahd);
                        cmdCTHoaDonUpdate.Parameters.AddWithValue("@Masp", masp);
                        cmdCTHoaDonUpdate.Parameters.AddWithValue("@Soluong", soluong);
                        cmdCTHoaDonUpdate.Parameters.AddWithValue("@Dongia", dongia);

                        cmdCTHoaDonUpdate.ExecuteNonQuery();

                        // 5. Cập nhật số lượng trong bảng SanPham
                        string queryUpdateSanPham = "UPDATE SanPham SET Soluong = Soluong - @Soluong WHERE Masp = @Masp";
                        SqlCommand cmdUpdateSanPham = new SqlCommand(queryUpdateSanPham, kn.Connection);
                        cmdUpdateSanPham.Parameters.AddWithValue("@Masp", masp);
                        cmdUpdateSanPham.Parameters.AddWithValue("@Soluong", soluong);

                        try
                        {
                            int rowsAffectedSanPham = cmdUpdateSanPham.ExecuteNonQuery();
                            if (rowsAffectedSanPham == 0)
                                MessageBox.Show($"Sản phẩm {masp} không đủ số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi cập nhật số lượng sản phẩm {masp}: {ex.Message}");
                        }
                    }
                }

                MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới giao diện
                hienthihoadon.Rows.Clear();

                frmCTHoaDon chiTietForm = new frmCTHoaDon(mahd);
                chiTietForm.Show();

                ClearTextBoxes();
                ClearTextBoxes1();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi thanh toán hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (kn.Connection.State == ConnectionState.Open)
                    kn.Connection.Close();
            }

        }


        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            float giamGia = 0;
            if (string.IsNullOrWhiteSpace(txtgiamgia.Text))
            {
                giamGia = 0; // Nếu không nhập giảm giá, mặc định là 0
            }
            else
            {
                // Thử chuyển đổi giá trị giảm giá
                try
                {
                    giamGia = float.Parse(txtgiamgia.Text);
                    if (giamGia < 0 || giamGia > 1)
                    {
                        MessageBox.Show("Giảm giá phải nằm trong khoảng từ 0 đến 1 (ví dụ: 0.1 cho 10%)", "Lỗi");
                        txtgiamgia.Text = "0";
                        giamGia = 0;
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập giá trị giảm giá hợp lệ.", "Lỗi");
                    txtgiamgia.Text = "0";
                    giamGia = 0;
                    return;
                }
            }

            // Tính tổng tiền từ bảng DataGridView
            float tongTien = float.Parse(txttongtien.Text);


            // Tính tiền thanh toán sau khi áp dụng giảm giá
            float tienThanhToan = tongTien * (1 - giamGia);

            // Hiển thị tổng tiền thanh toán
            txtthanhtoan.Text = tienThanhToan.ToString("N2");
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btthemkh_Click(object sender, EventArgs e)
        {
            frmthemkh formThemKhachHang = new frmthemkh(this);
            formThemKhachHang.ShowDialog();
        }

        private void txtsodt_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtsodt_TextChanged(object sender, EventArgs e)
        {
            string sodt = txtsodt.Text.Trim();

            if (string.IsNullOrEmpty(sodt))
                return;

            try
            {
                if (kn.Connection.State != ConnectionState.Open)
                    kn.Connection.Open();

                string query = "SELECT Tenkh, Diachi FROM KhachHang WHERE Sodt = @Sodt";

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    command.Parameters.AddWithValue("@Sodt", sodt);

                    // Sử dụng using statement để đảm bảo SqlDataReader được đóng tự động
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txttenkh.Text = reader["Tenkh"].ToString();
                            txtdiachi.Text = reader["Diachi"].ToString();

                            btthemkh.Visible = false;  // Ẩn button "Thêm khách hàng" vì đã tìm thấy khách hàng
                        }
                        else
                        {
                            txttenkh.Text = "";
                            txtdiachi.Text = "";

                            btthemkh.Visible = true;  // Hiển button "Thêm khách hàng" nếu không tìm thấy khách hàng
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (kn.Connection.State == ConnectionState.Open)
                    kn.Connection.Close();  // Đảm bảo kết nối được đóng sau khi xong
            }
        }
    }
}
