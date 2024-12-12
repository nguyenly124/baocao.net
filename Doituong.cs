using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONGHODEOTAY
{
    public class Doituong
    {
        public class Nguoidung
        {
            public string Tendn { get; set; }
            public string Matkhau { get; set; }

            public string Thuoctinh { get; set; }
            // Constructor mặc định
           

            // Ghi đè ToString() để hiển thị thông tin
            public override string ToString()
            {
                return $"Tên đăng nhập: {Tendn}, Thuộc tính: {Thuoctinh}";
            }
        }
        public class NguoidungRepository
        {
            ketnoi kn = new ketnoi();

            public Nguoidung GetUserByCredentials(string tendn, string matkhau, string role)
            {
                string query = "SELECT Tendn, Matkhau, Thuoctinh FROM TaiKhoan WHERE Tendn = @Tendn AND Matkhau = @Matkhau AND Thuoctinh=@Thuoctinh";

                try
                {
                    // Sử dụng 'using' để tự động đóng kết nối
                    using (SqlConnection connection = kn.Connection)
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Tendn", tendn);
                            command.Parameters.AddWithValue("@Matkhau", matkhau);
                            command.Parameters.AddWithValue("@Thuoctinh", role);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return new Nguoidung
                                    {
                                        Tendn = reader.GetString(0),
                                        Matkhau = reader.GetString(1),
                                        Thuoctinh = reader.GetString(2)
                                    };
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi truy vấn cơ sở dữ liệu: {ex.Message}");
                }

                return null;
            }

        }

        public class SanPham
        {
            public string Masp { get; set; }
            public string Tensp { get; set; }
            public decimal Gia { get; set; }
            public int Soluong  { get; set; }
        }
        public class HoaDon
        {
            public string Mahd { get; set; }
            public string Manv { get; set; }
            public string Makh { get; set; }
            public string Tensp { get; set; }
            public int SoLuong { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien { get; set; }

        }
    }
}
