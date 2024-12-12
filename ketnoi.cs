using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DONGHODEOTAY
{
    internal class ketnoi
    {
        string conStr = @"Data Source=MSI;Initial Catalog=QUANLYDONGHO;Integrated Security=True;";
        SqlConnection conn;
        public SqlConnection Connection { get { return conn; } }

        public ketnoi()
        {
            conn = new SqlConnection(conStr);
        }

        // Kiểm tra kết nối cơ sở dữ liệu
        public bool KiemTraKetNoi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open(); // Mở kết nối nếu chưa mở

                MessageBox.Show("Kết nối thành công!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Đảm bảo đóng kết nối sau khi kiểm tra
            }
        }

        // Lấy dữ liệu từ cơ sở dữ liệu
        public DataSet LayDuLieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();

                // Mở kết nối trước khi thực hiện truy vấn
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(truyvan, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Đảm bảo đóng kết nối
            }
        }

        // Thực thi câu lệnh không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public bool ThucThi(string truyvan)
        {
            try
            {
                // Mở kết nối trước khi thực thi câu lệnh
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                return r > 0; // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Đảm bảo đóng kết nối
            }
        }

    }
}
