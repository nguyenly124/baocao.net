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
        public frmBanHang()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        List<SanPham> danhSachSanPham = new List<SanPham>();

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

                foreach (DataGridViewRow row in hienthihoadon.Rows)
                {
                    if (row.Cells["Column1"].Value != null)
                    {
                        string maSanPham = row.Cells["column1"].Value.ToString();
                        int soLuong = int.Parse(row.Cells["column3"].Value.ToString());

                        // Cập nhật số lượng trong cơ sở dữ liệu
                        string query = "UPDATE SanPham SET Soluong = Soluong - @SoLuong WHERE Masp = @MaSanPham";
                        SqlCommand command = new SqlCommand(query, kn.Connection);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);
                        command.Parameters.AddWithValue("@MaSanPham", maSanPham);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thanh toán, xóa toàn bộ sản phẩm trong DataGridView
                hienthihoadon.Rows.Clear();
                ClearTextBoxes();
                TinhTongTien(); // Reset tổng tiền
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thanh toán: " + ex.Message);
            }
            finally
            {
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
    }
}
