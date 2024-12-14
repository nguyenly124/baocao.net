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

namespace DONGHODEOTAY
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            hienthikh.Columns["Column1"].DataPropertyName = "Makh";    // Mã NV
            hienthikh.Columns["Column2"].DataPropertyName = "Tenkh";   // Tên NV
            hienthikh.Columns["Column3"].DataPropertyName = "Gioitinh";  // Địa chỉ
            hienthikh.Columns["Column4"].DataPropertyName = "Sodt";
            hienthikh.Columns["Column5"].DataPropertyName = "Diachi";
            hienthikh.Columns["Column6"].DataPropertyName = "Luotmua";
            Getdata();
        }
        public void Getdata()
        {


            try
            {
                string query = "SELECT * FROM KhachHang";
                DataSet ds = kn.LayDuLieu(query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    hienthikh.DataSource = ds.Tables[0]; // Gán dữ liệu vào DataGridView

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }

            // Lấy thông tin từ các TextBox
            string makh = txtma.Text.Trim();
            string tenkh = txtten.Text.Trim();
            string gioitinh = txtgioitinh.Text.Trim();
            string diachi = txtdiachi.Text.Trim();
            string sodt = txtsodt.Text.Trim();


            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(makh) || string.IsNullOrEmpty(tenkh) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sodt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(sodt, out _)) // Kiểm tra số điện thoại là số
            {
                MessageBox.Show("Số điện thoại phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in hienthikh.Rows)
            {
                if (row.Cells["Sodt"].Value != null && row.Cells["Sodt"].Value.ToString() == sodt)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Thoát khỏi sự kiện thêm nếu trùng
                }
            }

            // Câu lệnh SQL thêm nhân viên
            string query = "INSERT INTO khachhang (Tenkh, Gioitinh, Sodt, Diachi) VALUES (@tenkh, @gioitinh, @sodt, @diachi)";

            try
            {

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@tenkh", tenkh);
                    command.Parameters.AddWithValue("@gioitinh", gioitinh);
                    command.Parameters.AddWithValue("@diachi", diachi);
                    command.Parameters.AddWithValue("@sodt", sodt);

                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu sau khi thêm thành công
                        Getdata(); // Làm mới danh sách nhân viên trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txtdiachi.Clear();
            txtgioitinh.Clear();
            txtluotmua.Clear();
            txtma.Clear();
            txtsodt.Clear();
            txtten.Clear();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Lấy thông tin từ các TextBox
            string makh = txtma.Text.Trim();
            string tenkh = txtten.Text.Trim();
            string gioitinh = txtgioitinh.Text.Trim();
            string diachi = txtdiachi.Text.Trim();
            string sodt = txtsodt.Text.Trim();
            string luotmua = txtluotmua.Text.Trim();
            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(makh) || string.IsNullOrEmpty(tenkh) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sodt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(sodt, out _)) // Kiểm tra số điện thoại là số
            {
                MessageBox.Show("Số điện thoại phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL cập nhật
            string query = "UPDATE KhachHang SET Tenkh = @Tenkh, Gioitinh=@Gioitinh, Sodt = @Sodt,Diachi = @Diachi,Luotmua=@Luotmua WHERE Makh = @Makh";

            try
            {
                // Thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@Makh", makh);
                    command.Parameters.AddWithValue("@Tenkh", tenkh);
                    command.Parameters.AddWithValue("@Gioitinh", gioitinh);
                    command.Parameters.AddWithValue("@Diachi", diachi);
                    command.Parameters.AddWithValue("@Sodt", sodt);
                    command.Parameters.AddWithValue("@Luotmua", luotmua);
                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu trong các TextBox
                        Getdata(); // Cập nhật lại danh sách trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Lấy thông tin từ các TextBox
            string makh = txtma.Text.Trim();
            if (string.IsNullOrEmpty(makh))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var tb = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                // SQL query to delete the employee by Manv
                string query = "DELETE FROM KhachHang WHERE Makh = @Makh";
                try
                {
                    // Thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, kn.Connection))
                    {
                        // Gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@Makh", makh);


                        // Thực hiện câu lệnh
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes(); // Xóa dữ liệu trong các TextBox
                            Getdata(); // Cập nhật lại danh sách trên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để Xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void hienthikh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra chỉ số hàng được click
                if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề cột
                {
                    // Lấy hàng được chọn
                    DataGridViewRow selectedRow = hienthikh.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtma.Text = selectedRow.Cells["Column1"].Value?.ToString() ?? "";
                    txtten.Text = selectedRow.Cells["Column2"].Value?.ToString() ?? "";
                    txtgioitinh.Text = selectedRow.Cells["Column3"].Value?.ToString() ?? "";
                    txtsodt.Text = selectedRow.Cells["Column4"].Value?.ToString() ?? "";
                    txtdiachi.Text = selectedRow.Cells["Column5"].Value?.ToString() ?? "";
                    txtluotmua.Text = selectedRow.Cells["Column6"].Value?.ToString() ?? "";

                    int makh = Convert.ToInt32(selectedRow.Cells["Column1"].Value);

                    // Hiển thị danh sách hóa đơn
                    Loadhoadon(makh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Loadhoadon(int makh)
        {
            try
            {
                if (kn.Connection.State != ConnectionState.Open)
                    kn.Connection.Open();

                string query = "SELECT Mahd, Ngaytao, Tienban, Giamgia, Thanhtoan FROM HoaDon WHERE Makh = @Makh";

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    command.Parameters.AddWithValue("@Makh", makh);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Tắt AutoGenerateColumns để sử dụng các cột có sẵn
                        hienthihoadon.AutoGenerateColumns = false;

                        // Gán dữ liệu vào DataGridView
                        hienthihoadon.DataSource = dt;

                        // Liên kết cột DataPropertyName với các trường trong DataTable
                        hienthihoadon.Columns["Column7"].DataPropertyName = "Mahd";
                        hienthihoadon.Columns["Column8"].DataPropertyName = "Ngaytao";
                        hienthihoadon.Columns["Column9"].DataPropertyName = "Tienban";
                        hienthihoadon.Columns["Column10"].DataPropertyName = "Giamgia";
                        hienthihoadon.Columns["Column11"].DataPropertyName = "Thanhtoan";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int selectedMahd = 0;
        private void hienthihoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Lấy Mã hóa đơn từ cột "Mahd" trong hàng được click
                    selectedMahd = Convert.ToInt32(hienthihoadon.Rows[e.RowIndex].Cells["Column7"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể lấy Mã hóa đơn: {ex.Message}");
                }
            }
            if (selectedMahd == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trước khi xem chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở Form chi tiết hóa đơn mới và truyền Mã hóa đơn đã chọn
            frmCTHoaDon chiTietForm = new frmCTHoaDon(selectedMahd);
            chiTietForm.Show();
        }
    }
}
