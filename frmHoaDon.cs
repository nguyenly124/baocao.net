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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            hienthi.Columns["Mahd"].DataPropertyName = "Mahd";    // Mã NV
            hienthi.Columns["ngaytao"].DataPropertyName = "Ngaytao";   // Tên NV
            hienthi.Columns["nhanvien"].DataPropertyName = "Tennv";  // Địa chỉ
            hienthi.Columns["khachhang"].DataPropertyName = "Tenkh";
            hienthi.Columns["tienban"].DataPropertyName = "Tienban";
            hienthi.Columns["giamgia"].DataPropertyName = "Giamgia";
            hienthi.Columns["thanhtoan"].DataPropertyName = "Thanhtoan";

            Getdata();

        }
        public void Getdata()
        {
            try
            {
                string query = @"SELECT hd.Mahd, hd.Ngaytao, nv.Tennv, kh.Tenkh, hd.Tienban, 
                         hd.Giamgia, hd.Thanhtoan
                         FROM HoaDon hd 
                         INNER JOIN NhanVien nv ON hd.Manv = nv.Manv 
                         INNER JOIN KhachHang kh ON hd.Makh = kh.Makh";
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
        private int selectedMahd = 0;
        private void btxoa_Click(object sender, EventArgs e)
        {
            if (selectedMahd == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trước khi xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (kn.Connection.State != ConnectionState.Open)
                    kn.Connection.Open();

                using (SqlTransaction transaction = kn.Connection.BeginTransaction())
                {
                    try
                    {
                        // Xóa chi tiết hóa đơn trước
                        string deleteCTHoaDon = "DELETE FROM CTHoaDon WHERE Mahd = @Mahd";
                        SqlCommand cmdDeleteCTHoaDon = new SqlCommand(deleteCTHoaDon, kn.Connection, transaction);
                        cmdDeleteCTHoaDon.Parameters.AddWithValue("@Mahd", selectedMahd);
                        cmdDeleteCTHoaDon.ExecuteNonQuery();

                        // Xóa hóa đơn chính
                        string deleteHoaDon = "DELETE FROM HoaDon WHERE Mahd = @Mahd";
                        SqlCommand cmdDeleteHoaDon = new SqlCommand(deleteHoaDon, kn.Connection, transaction);
                        cmdDeleteHoaDon.Parameters.AddWithValue("@Mahd", selectedMahd);
                        cmdDeleteHoaDon.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại dữ liệu DataGridView
                        Getdata();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Có lỗi khi xóa hóa đơn: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kết nối database thất bại: {ex.Message}");
            }
            finally
            {
                if (kn.Connection.State == ConnectionState.Open)
                    kn.Connection.Close();
            }
        }

        private void hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Lấy Mã hóa đơn từ cột "Mahd" trong hàng được click
                    selectedMahd = Convert.ToInt32(hienthi.Rows[e.RowIndex].Cells["Mahd"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể lấy Mã hóa đơn: {ex.Message}");
                }
            }
        }

        private void btct_Click(object sender, EventArgs e)
        {
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
