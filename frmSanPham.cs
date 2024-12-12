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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DONGHODEOTAY
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            hienthi.Columns["Column1"].DataPropertyName = "Masp";    // Mã NV
            hienthi.Columns["Column2"].DataPropertyName = "Tensp";   // Tên NV
            hienthi.Columns["Column3"].DataPropertyName = "Soluong";  // Địa chỉ
            hienthi.Columns["Column4"].DataPropertyName = "Gianhap";
            hienthi.Columns["Column5"].DataPropertyName = "Giaban";
            hienthi.Columns["Column6"].DataPropertyName = "Tenloaisp";
            hienthi.Columns["Column7"].DataPropertyName = "Tenncc";
            hienthi.Columns["Column8"].DataPropertyName = "Mota";
            txtloaisp.SelectedIndex = -1;
            txtnhacc.SelectedIndex = -1;
            Getdata();
            LoadDataToComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Getdata()
        {


            try
            {
                string query = @"SELECT sp.Masp, sp.Tensp, sp.Soluong, sp.Gianhap, sp.Giaban, 
                         ls.Tenloaisp, ns.Tenncc, sp.Mota
                         FROM SanPham sp 
                         INNER JOIN LoaiSP ls ON sp.Maloaisp = ls.Maloaisp 
                         INNER JOIN NhaCungCap ns ON sp.Mancc = ns.Mancc"; 
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
        private void LoadDataToComboBox()
        {
            // Câu truy vấn
            string query1 = "SELECT Tenncc FROM NhaCungCap"; // Cho ComboBox txtncc
            string query2 = "SELECT Tenloaisp FROM Loaisp";  // Cho ComboBox txtloaisp

            try
            {
                // Mở kết nối nếu chưa mở
                if (kn.Connection.State != ConnectionState.Open)
                {
                    kn.Connection.Open();
                }

                // Xử lý dữ liệu cho ComboBox txtncc
                using (SqlCommand command1 = new SqlCommand(query1, kn.Connection))
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable dataTable1 = new DataTable();
                    adapter1.Fill(dataTable1);

                    // Gắn dữ liệu vào ComboBox txtncc
                    txtnhacc.DataSource = dataTable1;
                    txtnhacc.DisplayMember = "Tenncc"; // Tên cột hiển thị
                }

                // Xử lý dữ liệu cho ComboBox txtloaisp
                using (SqlCommand command2 = new SqlCommand(query2, kn.Connection))
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                    DataTable dataTable2 = new DataTable();
                    adapter2.Fill(dataTable2);

                    // Gắn dữ liệu vào ComboBox txtloaisp
                    txtloaisp.DataSource = dataTable2;
                    txtloaisp.DisplayMember = "Tenloaisp"; // Tên cột hiển thị
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }




        private void btxoa_Click(object sender, EventArgs e)
        {

            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Lấy thông tin từ các TextBox
            string masp = txtma.Text.Trim();
            if (string.IsNullOrEmpty(masp))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var tb = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                // SQL query to delete the employee by Manv
                string query = "DELETE FROM SanPham WHERE Masp = @ma";
                try
                {
                    // Thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, kn.Connection))
                    {
                        // Gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@ma", masp);


                        // Thực hiện câu lệnh
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    txtma.Text = selectedRow.Cells["Column1"].Value?.ToString() ?? "";
                    txtten.Text = selectedRow.Cells["Column2"].Value?.ToString() ?? "";
                    txtsoluong.Text = selectedRow.Cells["Column3"].Value?.ToString() ?? "";
                    txtgianhap.Text = selectedRow.Cells["Column4"].Value?.ToString() ?? "";
                    txtgiaban.Text = selectedRow.Cells["Column5"].Value?.ToString() ?? "";
                    txtloaisp.Text = selectedRow.Cells["Column6"].Value?.ToString() ?? "";
                    txtnhacc.Text = selectedRow.Cells["Column7"].Value?.ToString() ?? "";
                    txtmota.Text = selectedRow.Cells["Column8"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }

            // Lấy thông tin từ các TextBox
            string ten = txtten.Text.Trim();
            string soluong = txtsoluong.Text.Trim();
            string gianhap = txtgianhap.Text.Trim();
            string giaban = txtgiaban.Text.Trim();
            string mota = txtmota.Text.Trim();

            // Lấy tên loại sản phẩm và tên nhà cung cấp từ ComboBox
            string tenLoaiSP = txtloaisp.Text.Trim();
            string tenNhaCC = txtnhacc.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(soluong) ||
                string.IsNullOrWhiteSpace(gianhap) || string.IsNullOrWhiteSpace(giaban) ||
                string.IsNullOrWhiteSpace(mota) || string.IsNullOrWhiteSpace(tenLoaiSP) || string.IsNullOrWhiteSpace(tenNhaCC))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soluong, out _) || !float.TryParse(gianhap, out _) || !float.TryParse(giaban, out _))
            {
                MessageBox.Show("Số lượng, giá nhập và giá bán phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM SanPham WHERE Tensp = @ten";
            try
            {
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, kn.Connection))
                {
                    checkCommand.Parameters.AddWithValue("@ten", ten);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy mã loại sản phẩm (Maloaisp) và mã nhà cung cấp (Mancc) từ tên
            int maloaisp = 0, mancc = 0;

            try
            {
                // Lấy mã loại sản phẩm từ tên loại sản phẩm
                string queryLoaiSP = "SELECT Maloaisp FROM Loaisp WHERE Tenloaisp = @tenLoaiSP";
                using (SqlCommand cmdLoaiSP = new SqlCommand(queryLoaiSP, kn.Connection))
                {
                    cmdLoaiSP.Parameters.AddWithValue("@tenLoaiSP", tenLoaiSP);
                    maloaisp = (int)cmdLoaiSP.ExecuteScalar(); // Trả về mã loại sản phẩm
                }

                // Lấy mã nhà cung cấp từ tên nhà cung cấp
                string queryNhaCC = "SELECT Mancc FROM NhaCungCap WHERE Tenncc = @tenNhaCC";
                using (SqlCommand cmdNhaCC = new SqlCommand(queryNhaCC, kn.Connection))
                {
                    cmdNhaCC.Parameters.AddWithValue("@tenNhaCC", tenNhaCC);
                    mancc = (int)cmdNhaCC.ExecuteScalar(); // Trả về mã nhà cung cấp
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã loại sản phẩm hoặc mã nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Câu lệnh SQL thêm sản phẩm (không cần đưa mã sản phẩm vào, vì nó sẽ tự động tăng)
            string query = "INSERT INTO SanPham (Tensp, Soluong, Gianhap, Giaban, Maloaisp, Mancc, Mota) " +
                           "VALUES (@ten, @soluong, @gianhap, @giaban, @maloaisp, @mancc, @mota)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@soluong", soluong);
                    command.Parameters.AddWithValue("@gianhap", gianhap);
                    command.Parameters.AddWithValue("@giaban", giaban);
                    command.Parameters.AddWithValue("@maloaisp", maloaisp);
                    command.Parameters.AddWithValue("@mancc", mancc);
                    command.Parameters.AddWithValue("@mota", mota);

                    // Thực thi câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu sau khi thêm thành công
                        Getdata(); // Làm mới danh sách sản phẩm trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtma.Clear();
            txtten.Clear();
            txtsoluong.Clear();
            txtgianhap.Clear();
            txtgiaban.Clear();
            txtmota.Clear();
            txtloaisp.SelectedIndex = -1;
            txtnhacc.SelectedIndex = -1;
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
            string gianhap = txtgianhap.Text.Trim();
            string giaban = txtgiaban.Text.Trim();
            string mota = txtmota.Text.Trim();

            // Lấy tên loại sản phẩm và tên nhà cung cấp từ ComboBox
            string tenLoaiSP = txtloaisp.Text.Trim();
            string tenNhaCC = txtnhacc.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(soluong) ||
                string.IsNullOrWhiteSpace(gianhap) || string.IsNullOrWhiteSpace(giaban) ||
                string.IsNullOrWhiteSpace(mota) || string.IsNullOrWhiteSpace(tenLoaiSP) || string.IsNullOrWhiteSpace(tenNhaCC))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soluong, out _) || !float.TryParse(gianhap, out _) || !float.TryParse(giaban, out _))
            {
                MessageBox.Show("Số lượng, giá nhập và giá bán phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã loại sản phẩm (Maloaisp) và mã nhà cung cấp (Mancc) từ tên
            int maloaisp = 0, mancc = 0;
            try
            {
                // Lấy mã loại sản phẩm từ tên loại sản phẩm
                string queryLoaiSP = "SELECT Maloaisp FROM Loaisp WHERE Tenloaisp = @tenLoaiSP";
                using (SqlCommand cmdLoaiSP = new SqlCommand(queryLoaiSP, kn.Connection))
                {
                    cmdLoaiSP.Parameters.AddWithValue("@tenLoaiSP", tenLoaiSP);
                    maloaisp = (int)cmdLoaiSP.ExecuteScalar(); // Trả về mã loại sản phẩm
                }

                // Lấy mã nhà cung cấp từ tên nhà cung cấp
                string queryNhaCC = "SELECT Mancc FROM NhaCungCap WHERE Tenncc = @tenNhaCC";
                using (SqlCommand cmdNhaCC = new SqlCommand(queryNhaCC, kn.Connection))
                {
                    cmdNhaCC.Parameters.AddWithValue("@tenNhaCC", tenNhaCC);
                    mancc = (int)cmdNhaCC.ExecuteScalar(); // Trả về mã nhà cung cấp
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã loại sản phẩm hoặc mã nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Câu lệnh SQL cập nhật
            string query = "UPDATE SanPham SET Tensp = @ten, Soluong = @soluong, Gianhap = @gianhap, Giaban=@giaban,Maloaisp=@maloaisp,Mancc=@mancc,Mota=@mota  WHERE Masp = @ma";

            try
            {
                // Thực thi câu lệnh SQL
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@ma", ma);
                    command.Parameters.AddWithValue("@ten", ten);
                    command.Parameters.AddWithValue("@soluong", soluong);
                    command.Parameters.AddWithValue("@gianhap", gianhap);
                    command.Parameters.AddWithValue("@giaban", giaban);
                    command.Parameters.AddWithValue("@maloaisp", maloaisp);
                    command.Parameters.AddWithValue("@mancc", mancc);
                    command.Parameters.AddWithValue("@mota", mota);

                    // Thực hiện câu lệnh
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Xóa dữ liệu trong các TextBox
                        Getdata(); // Cập nhật lại danh sách trên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
                string searchText = txttimkiem.Text.Trim(); // Lấy thông tin từ TextBox tìm kiếm

                if (kn.Connection.State != ConnectionState.Open)
                {
                    kn.Connection.Open();
                }

                try
                {
                    string query;

                    // Nếu người dùng không nhập gì, hiển thị tất cả sản phẩm
                    if (string.IsNullOrEmpty(searchText))
                    {
                        query = "SELECT sp.Masp, sp.Tensp, sp.Soluong, sp.Gianhap, sp.Giaban, ls.Tenloaisp, ns.Tenncc, sp.Mota " +
                                "FROM SanPham sp " +
                                "INNER JOIN LoaiSP ls ON sp.Maloaisp = ls.Maloaisp " +
                                "INNER JOIN NhaCungCap ns ON sp.Mancc = ns.Mancc";
                    }
                    else
                    {
                        query = "SELECT sp.Masp, sp.Tensp, sp.Soluong, sp.Gianhap, sp.Giaban, ls.Tenloaisp, ns.Tenncc, sp.Mota " +
                                "FROM SanPham sp " +
                                "INNER JOIN LoaiSP ls ON sp.Maloaisp = ls.Maloaisp " +
                                "INNER JOIN NhaCungCap ns ON sp.Mancc = ns.Mancc " +
                                "WHERE sp.Masp LIKE @SearchText OR sp.Tensp LIKE @SearchText";
                    }

                    using (SqlCommand command = new SqlCommand(query, kn.Connection))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();

                        // Lấy dữ liệu vào DataSet
                        adapter.Fill(ds);

                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            hienthi.DataSource = ds.Tables[0]; // Hiển thị dữ liệu trên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy kết quả tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienthi.DataSource = null; // Xóa dữ liệu trên DataGridView nếu không tìm thấy kết quả
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
