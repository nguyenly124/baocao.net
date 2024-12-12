using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DONGHODEOTAY
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();

        }
        ketnoi kn = new ketnoi();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        public void Getdata()
        {


            try
            {
                string query = @"SELECT ID,Tendn,Matkhau,Thuoctinh FROM Taikhoan ";
                DataSet ds = kn.LayDuLieu(query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //hienthi.Columns.Clear(); // Xóa các cột hiện tại
                    //hienthi.DataSource = null; // Đảm bảo không còn dữ liệu cũ

                    hienthi.DataSource = ds.Tables[0]; // Gán dữ liệu mới vào DataGridView
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

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {

            hienthi.Columns["Column1"].DataPropertyName = "ID";    // Mã NV
            hienthi.Columns["Column2"].DataPropertyName = "Tendn";   // Tên NV
            hienthi.Columns["Column3"].DataPropertyName = "Matkhau";  // Địa chỉ
            hienthi.Columns["Column4"].DataPropertyName = "Thuoctinh";

            Getdata();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            string ten = txtten.Text.Trim();
            string matkhau = txtmatkhau.Text.Trim();
            string thuoctinh = txttaikhoan.Text.Trim();
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(matkhau) ||
                string.IsNullOrWhiteSpace(thuoctinh))
            {

                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (ten.Length < 6 || matkhau.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu phải có tối đa 6 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM Taikhoan WHERE Tendn = @ten";
            try
            {
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, kn.Connection))
                {
                    checkCommand.Parameters.AddWithValue("@ten", ten);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi  " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "INSERT INTO Taikhoan (Tendn, Matkhau , Thuoctinh) " +
                           "VALUES (@ten, @matkhau, @taikhoan)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@matkhau", matkhau);
                    command.Parameters.AddWithValue("@taikhoan", thuoctinh);


                    // Thực thi câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu sau khi thêm thành công
                        Getdata(); // Làm mới danh sách sản phẩm trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtID.Clear();
            txtten.Clear();
            txtmatkhau.Clear();
            txttaikhoan.SelectedIndex = -1;

        }
        private void hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề cột
                {
                    // Lấy hàng được chọn
                    DataGridViewRow selectedRow = hienthi.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtID.Text= selectedRow.Cells["Column1"].Value?.ToString() ?? "";
                    txtten.Text = selectedRow.Cells["Column2"].Value?.ToString() ?? "";
                    txtmatkhau.Text = selectedRow.Cells["Column3"].Value?.ToString() ?? "";
                    txttaikhoan.Text = selectedRow.Cells["Column4"].Value?.ToString() ?? "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Lấy thông tin từ các TextBox
            string ten = txtten.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng chọn thông tin để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var tb = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                // SQL query to delete the employee by Manv
                string query = "DELETE FROM Taikhoan WHERE Tendn = @ten";
                try
                {
                    // Thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, kn.Connection))
                    {
                        // Gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@ten", ten);


                        // Thực hiện câu lệnh
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes(); // Xóa dữ liệu trong các TextBox
                            Getdata(); // Cập nhật lại danh sách trên DataGridView
                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }

            // Lấy dữ liệu từ các TextBox
            string ID = txtID.Text.Trim();
            string ten = txtten.Text.Trim();
            string matkhau = txtmatkhau.Text.Trim();
            string thuoctinh = txttaikhoan.Text.Trim();

            // Kiểm tra các trường nhập dữ liệu không được trống
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(matkhau) ||
                string.IsNullOrWhiteSpace(thuoctinh) || string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài tên đăng nhập và mật khẩu tối thiểu 6 ký tự
            if (ten.Length < 6 || matkhau.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu phải có tối thiểu 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM Taikhoan WHERE Tendn = @ten";
            try
            {
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, kn.Connection))
                {
                    checkCommand.Parameters.AddWithValue("@ten", ten);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi  " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Câu lệnh SQL cập nhật thông tin tài khoản theo ID
                string query = "UPDATE Taikhoan SET Tendn = @ten, Matkhau = @matkhau, Thuoctinh = @taikhoan WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị tham số
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@matkhau", matkhau);
                    command.Parameters.AddWithValue("@taikhoan", thuoctinh);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu sau khi cập nhật thành công
                        Getdata();         // Làm mới danh sách trên DataGridView (nếu cần)
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
}
