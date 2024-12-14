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
    public partial class frmthemkh : Form
    {
        public frmthemkh(frmBanHang formBanHang)
        {
            InitializeComponent();
            banhangfrm = formBanHang;
        }
        ketnoi kn = new ketnoi();
        private frmBanHang banhangfrm;
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (kn.Connection.State != ConnectionState.Open)
                    kn.Connection.Open();

                KhachHang kh = new KhachHang
                {
                    Tenkh = txtten.Text.Trim(),
                    Gioitinh = txtgt.Text.Trim(),
                    Sodt = txtsodt.Text.Trim(),
                    Diachi = txtdiachi.Text.Trim()
                };

                string query = "INSERT INTO KhachHang (Tenkh, Gioitinh, Sodt, Diachi) VALUES (@Tenkh, @Gioitinh, @Sodt, @Diachi)";

                using (SqlCommand command = new SqlCommand(query, kn.Connection))
                {
                    command.Parameters.AddWithValue("@Tenkh", kh.Tenkh);
                    command.Parameters.AddWithValue("@Gioitinh", kh.Gioitinh);
                    command.Parameters.AddWithValue("@Sodt", kh.Sodt);
                    command.Parameters.AddWithValue("@Diachi", kh.Diachi);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Khách hàng đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();  // Đóng form thêm khách hàng

                        if (banhangfrm != null)
                        {
                            banhangfrm.SetCustomerInfo(kh);  // Cập nhật thông tin khách hàng về form bán hàng
                        }
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
