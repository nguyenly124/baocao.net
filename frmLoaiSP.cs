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
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void Getdata()
        {


            try
            {
                string query = "SELECT * FROM LoaiSP";
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

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            hienthi.Columns["Column1"].DataPropertyName = "Maloaisp";    // Mã NV
            hienthi.Columns["Column2"].DataPropertyName = "Tenloaisp";   // Tên NV
            hienthi.Columns["Column3"].DataPropertyName = "Soluong";  // Địa chỉ

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
                    txtma.Text = selectedRow.Cells["Column1"].Value?.ToString() ?? "";
                    txtten.Text = selectedRow.Cells["Column2"].Value?.ToString() ?? "";
                    txtsoluong.Text = selectedRow.Cells["Column3"].Value?.ToString() ?? "";
                    string maloaisp = hienthi.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                    Hienthisanpham(maloaisp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxes()
        {
            txtma.Clear();
            txtsoluong.Clear();
            txtten.Clear();

        }
        private void Hienthisanpham(string maloaisp)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                if (kn.Connection.State != ConnectionState.Open)
                {
                    kn.Connection.Open();
                }

                // Câu truy vấn để lấy danh sách sản phẩm thuộc loại sản phẩm
                string query = "SELECT Masp, Tensp, Soluong, Giaban FROM SanPham WHERE Maloaisp = @maloaisp";

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    command.Parameters.AddWithValue("@maloaisp", maloaisp);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                     hienthisp.AutoGenerateColumns = false;
                    // Gán dữ liệu vào DataGridView
                    hienthisp.DataSource = dataTable;
                   
                    // Gắn DataPropertyName nếu cột đã được cấu hình trong DataGridView
                    hienthisp.Columns["Column4"].DataPropertyName = "Masp";     // Cột 4 hiển thị Mã sản phẩm
                    hienthisp.Columns["Column5"].DataPropertyName = "Tensp";    // Cột 5 hiển thị Tên sản phẩm
                    hienthisp.Columns["Column6"].DataPropertyName = "Soluong";  // Cột 6 hiển thị Số lượng
                    hienthisp.Columns["Column7"].DataPropertyName = "Giaban";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }

            // Lấy thông tin từ các TextBox
            string ma = txtma.Text.Trim();
            string ten = txtten.Text.Trim();
            string soluong = txtsoluong.Text.Trim();


            // Kiểm tra dữ liệu hợp lệ
            if ( string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(soluong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(soluong, out _)) // Kiểm tra số điện thoại là số
            {
                MessageBox.Show("Nhập số lượng lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL thêm nhân viên
            string query = "INSERT INTO Loaisp ( Tenloaisp, Soluong) VALUES ( @Ten, @Soluong)";

            try
            {

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                 
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@Soluong", soluong);


                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu sau khi thêm thành công
                        Getdata(); // Làm mới danh sách nhân viên trên DataGridView
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

        private void btsua_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Lấy thông tin từ các TextBox
            string ma = txtma.Text.Trim();
            string ten = txtten.Text.Trim();
            string soluong = txtsoluong.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(soluong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(soluong, out _)) // Kiểm tra số điện thoại là số
            {
                MessageBox.Show("Nhập số lượng lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Câu lệnh SQL cập nhật
            string query = "UPDATE LoaiSP SET Tenloaisp = @Ten, Soluong = @Soluong WHERE Maloaisp = @Maloaisp";

            try
            {
                // Thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@Maloaisp", ma);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@Soluong", soluong);

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

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
