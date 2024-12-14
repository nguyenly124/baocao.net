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
    public partial class frmDangNhap : Form
    {
        private NguoidungRepository loginnguoidung ;
        public frmDangNhap()
        {
            InitializeComponent();
            loginnguoidung = new NguoidungRepository();
            LoadDataToComboBox();
        }
        ketnoi kn = new ketnoi();
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataToComboBox()
        {
            
            // Câu truy vấn
            string query1 = "SELECT DISTINCT Thuoctinh FROM TaiKhoan";

            try
            {
                if (kn.Connection.State != ConnectionState.Open)
                {
                    kn.Connection.Open();
                }
                // Sử dụng 'using' để đảm bảo kết nối được đóng tự động

                using (SqlCommand command1 = new SqlCommand(query1, kn.Connection))
                    {
                        SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                        DataTable dataTable1 = new DataTable();
                        adapter1.Fill(dataTable1);

                        txttaikhoan.DataSource = dataTable1;
                        txttaikhoan.DisplayMember = "Thuoctinh";
                    }
                    txttaikhoan.SelectedIndex = -1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
                kn.Connection.Open();

            string username = txtten.Text.Trim();
            string password = txtmatkhau.Text.Trim();
            string role = txttaikhoan.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT Tendn, Matkhau, Thuoctinh, Manv FROM TaiKhoan WHERE Tendn = @Tendn AND Matkhau = @Matkhau AND Thuoctinh = @Thuoctinh";

            try
            {
                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    command.Parameters.AddWithValue("@Tendn", username);
                    command.Parameters.AddWithValue("@Matkhau", password);
                    command.Parameters.AddWithValue("@Thuoctinh", role);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var nguoidung = new Nguoidung
                            {
                                Tendn = reader.GetString(0),
                                Matkhau = reader.GetString(1),
                                Thuoctinh = reader.GetString(2),
                                Manv = reader.GetInt32(3)  // Gán Manv
                            };

                            frmMain mainForm = new frmMain(nguoidung);
                            mainForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
