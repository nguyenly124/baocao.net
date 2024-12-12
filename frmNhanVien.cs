using System;
using System.Collections;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Getdata()
        {


            try
            {
                string query = "SELECT Manv, Tennv, Diachi, Sodt FROM NhanVien";
                DataSet ds = kn.LayDuLieu(query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    hienthi.DataSource = ds.Tables[0]; // Gán dữ liệu vào DataGridView

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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            hienthi.Columns["Column1"].DataPropertyName = "Manv";    // Mã NV
            hienthi.Columns["Column2"].DataPropertyName = "Tennv";   // Tên NV
            hienthi.Columns["Column3"].DataPropertyName = "Diachi";  // Địa chỉ
            hienthi.Columns["Column4"].DataPropertyName = "Sodt";
            Getdata();
        }

        private void hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra chỉ số hàng được click
                if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề cột
                {
                    // Lấy hàng được chọn
                    DataGridViewRow selectedRow = hienthi.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtManv.Text = selectedRow.Cells["Column1"].Value?.ToString() ?? "";
                    txtTennv.Text = selectedRow.Cells["Column2"].Value?.ToString() ?? "";
                    txtDiachi.Text = selectedRow.Cells["Column3"].Value?.ToString() ?? "";
                    txtSodt.Text = selectedRow.Cells["Column4"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bthem_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }

            // Lấy thông tin từ các TextBox
            string manv = txtManv.Text.Trim();
            string tennv = txtTennv.Text.Trim();
            string diachi = txtDiachi.Text.Trim();
            string sodt = txtSodt.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(tennv) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sodt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(sodt, out _)) // Kiểm tra số điện thoại là số
            {
                MessageBox.Show("Số điện thoại phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL thêm nhân viên
            string query = "INSERT INTO NhanVien (Manv, Tennv, Diachi, Sodt) VALUES (@Manv, @Tennv, @Diachi, @Sodt)";

            try
            {

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@Manv", manv);
                    command.Parameters.AddWithValue("@Tennv", tennv);
                    command.Parameters.AddWithValue("@Diachi", diachi);
                    command.Parameters.AddWithValue("@Sodt", sodt);

                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu sau khi thêm thành công
                        Getdata(); // Làm mới danh sách nhân viên trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtManv.Clear();
            txtTennv.Clear();
            txtDiachi.Clear();
            txtSodt.Clear();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Lấy thông tin từ các TextBox
            string manv = txtManv.Text.Trim();
            string tennv = txtTennv.Text.Trim();
            string diachi = txtDiachi.Text.Trim();
            string sodt = txtSodt.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(tennv) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sodt))
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
            string query = "UPDATE NhanVien SET Tennv = @Tennv, Diachi = @Diachi, Sodt = @Sodt WHERE Manv = @Manv";

            try
            {
                // Thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@Manv", manv);
                    command.Parameters.AddWithValue("@Tennv", tennv);
                    command.Parameters.AddWithValue("@Diachi", diachi);
                    command.Parameters.AddWithValue("@Sodt", sodt);

                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu trong các TextBox
                        Getdata(); // Cập nhật lại danh sách trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string manv = txtManv.Text.Trim();
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var tb = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                // SQL query to delete the employee by Manv
                string query = "DELETE FROM NhanVien WHERE Manv = @Manv";
                try
                {
                    // Thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, kn.Connection))
                    {
                        // Gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@Manv", manv);


                        // Thực hiện câu lệnh
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes(); // Xóa dữ liệu trong các TextBox
                            Getdata(); // Cập nhật lại danh sách trên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để Xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {

            string searchText = txttimkiem.Text.Trim(); // Assuming txtSearch is the TextBox where user enters the search query

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create the SQL query to search by employee ID or name
                string query = "SELECT Manv, Tennv, Diachi, Sodt FROM NhanVien WHERE Manv LIKE @SearchText OR Tennv LIKE @SearchText";
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%"); // Thêm tham số @SearchText với giá trị đã được chuẩn bị

                    // Tạo đối tượng DataAdapter để thực thi câu lệnh và lấy dữ liệu về
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();

                    // Lấy dữ liệu vào DataSet
                    adapter.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        hienthi.DataSource = ds.Tables[0]; // Hiển thị kết quả tìm kiếm trong DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
