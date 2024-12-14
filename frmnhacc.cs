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
    public partial class frmnhacc : Form
    {
        public frmnhacc()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void Getdata()
        {


            try
            {
                string query = "SELECT * FROM NhaCungCap";
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
        private void frmnhacc_Load(object sender, EventArgs e)
        {
            hienthi.Columns["Column1"].DataPropertyName = "Mancc";    // Mã NV
            hienthi.Columns["Column2"].DataPropertyName = "Tenncc";   // Tên NV
            hienthi.Columns["Column3"].DataPropertyName = "Hang";  // Địa chỉ
            hienthi.Columns["Column4"].DataPropertyName = "Sodt";   // Tên NV
            hienthi.Columns["Column5"].DataPropertyName = "Diachi";
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
                    txtid.Text = selectedRow.Cells["Column1"].Value?.ToString() ?? "";
                    txtten.Text = selectedRow.Cells["Column2"].Value?.ToString() ?? "";
                    txthang.Text = selectedRow.Cells["Column3"].Value?.ToString() ?? "";
                    txtsodt.Text = selectedRow.Cells["Column4"].Value?.ToString() ?? "";
                    txtdiachi.Text = selectedRow.Cells["Column5"].Value?.ToString() ?? "";
                    string id = hienthi.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                    Hienthisanpham(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxes()
        {
            txtid.Clear();
            txtten.Clear();
            txtsodt.Clear();
            txtdiachi.Clear();
            txthang.Clear();

        }
        private void Hienthisanpham(string id)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                if (kn.Connection.State != ConnectionState.Open)
                {
                    kn.Connection.Open();
                }

                // Câu truy vấn để lấy danh sách sản phẩm thuộc loại sản phẩm
                string query = "SELECT Masp, Tensp, Soluong, Giaban FROM SanPham WHERE Mancc = @id";

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    hienthisp.AutoGenerateColumns = false;
                    // Gán dữ liệu vào DataGridView
                    hienthisp.DataSource = dataTable;

                    // Gắn DataPropertyName nếu cột đã được cấu hình trong DataGridView
                    hienthisp.Columns["Column6"].DataPropertyName = "Masp";     // Cột 4 hiển thị Mã sản phẩm
                    hienthisp.Columns["Column7"].DataPropertyName = "Tensp";    // Cột 5 hiển thị Tên sản phẩm
                    hienthisp.Columns["Column8"].DataPropertyName = "Soluong";  // Cột 6 hiển thị Số lượng
                    hienthisp.Columns["Column9"].DataPropertyName = "Giaban";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Lấy thông tin từ các TextBox
            string ma = txtid.Text.Trim();
            string ten = txtten.Text.Trim();
            string hang = txthang.Text.Trim();
            string sodt = txtsodt.Text.Trim();
            string diachi = txtdiachi.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(hang) || string.IsNullOrEmpty(sodt) || string.IsNullOrEmpty(diachi) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(sodt, out _)) // Kiểm tra số điện thoại là số
            {
                MessageBox.Show("Nhập số điện thoại lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Câu lệnh SQL cập nhật
            string query = "UPDATE NhaCungCap SET Tenncc = @Ten, Hang = @Hang,Sodt=@Sodt,Diachi=@Diachi WHERE Mancc = @Mancc";

            try
            {
                // Thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@Mancc", ma);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@Hang", hang);
                    command.Parameters.AddWithValue("@Sodt", sodt);
                    command.Parameters.AddWithValue("@Diachi", diachi);

                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu trong các TextBox
                        Getdata(); // Cập nhật lại danh sách trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }

            // Lấy thông tin từ các TextBox
            string ma = txtid.Text.Trim();
            string ten = txtten.Text.Trim();
            string hang = txthang.Text.Trim();
            string sodt = txtsodt.Text.Trim();
            string diachi = txtdiachi.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(hang) || string.IsNullOrEmpty(sodt) || string.IsNullOrEmpty(diachi) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(sodt, out _)) // Kiểm tra số điện thoại là số
            {
                MessageBox.Show("Nhập số điện thoại lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL thêm nhân viên
            string query = "INSERT INTO NhaCungCap ( Tenncc,Hang,Sodt,Diachi) VALUES ( @Ten, @Hang,@Sodt,@Diachi)";

            try
            {

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số

                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@Hang", hang);
                    command.Parameters.AddWithValue("@Sodt", sodt);
                    command.Parameters.AddWithValue("@Diachi", diachi);


                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                        Getdata();
                    }
                    else
                    {
                        MessageBox.Show("Thêm  không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
