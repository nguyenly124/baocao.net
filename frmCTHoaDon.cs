using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace DONGHODEOTAY
{
    public partial class frmCTHoaDon : Form
    {
        public frmCTHoaDon(int mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }
        ketnoi kn = new ketnoi();
        private int mahd;

        private void LoadChiTietHoaDon()
        {
            try
            {
                // Lấy chi tiết sản phẩm từ CTHoaDon
                string queryCTHoaDon = @"
            SELECT ct.Mahd, sp.Tensp, ct.Soluong, ct.Dongia
            FROM CTHoaDon ct
            JOIN SanPham sp ON ct.Masp = sp.Masp
            WHERE ct.Mahd = @Mahd";

                if (kn.Connection.State != ConnectionState.Open)
                    kn.Connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(queryCTHoaDon, kn.Connection);
                da.SelectCommand.Parameters.AddWithValue("@Mahd", mahd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind dữ liệu vào DataGridView
                hienthi.AutoGenerateColumns = false;
                hienthi.DataSource = dt;

                hienthi.Columns["Column1"].DataPropertyName = "Mahd";
                hienthi.Columns["Column2"].DataPropertyName = "Tensp";
                hienthi.Columns["Column3"].DataPropertyName = "Soluong";
                hienthi.Columns["Column4"].DataPropertyName = "Dongia";

                // Hiển thị thông tin từ hóa đơn vào các TextBox
                string queryThongTinHoaDon = @"
            SELECT kh.Tenkh, nv.Tennv, hd.Ngaytao, hd.Tienban, hd.Giamgia, hd.Thanhtoan
            FROM HoaDon hd
            JOIN KhachHang kh ON hd.Makh = kh.Makh
            JOIN NhanVien nv ON hd.Manv = nv.Manv
            WHERE hd.Mahd = @Mahd";

                SqlCommand cmdThongTinHoaDon = new SqlCommand(queryThongTinHoaDon, kn.Connection);
                cmdThongTinHoaDon.Parameters.AddWithValue("@Mahd", mahd);

                SqlDataReader reader = cmdThongTinHoaDon.ExecuteReader();
                if (reader.Read())
                {
                    txtten.Text = reader["Tenkh"].ToString();
                    txtnv.Text = reader["Tennv"].ToString();
                    txtngay.Text = Convert.ToDateTime(reader["Ngaytao"]).ToString("dd/MM/yyyy");
                    txtthanhtien.Text = reader["Tienban"].ToString();
                    txtgiamgia.Text = reader["Giamgia"].ToString();
                    txtthanhtoan.Text = reader["Thanhtoan"].ToString();
                }
                reader.Close();

                kn.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi load chi tiết hóa đơn: {ex.Message}");
            }
        }

        private void frmCTHoaDon_Load(object sender, EventArgs e)
        {
            LoadChiTietHoaDon();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Hóa Đơn PDF";
                saveFileDialog.FileName = $"HoaDon_{mahd}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Tạo file PDF mới
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Alias namespace tránh xung đột giữa các Document khác nhau
                        iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 50, 50, 50, 50);
                        PdfWriter.GetInstance(document, fs);

                        document.Open();

                        // Nhúng font hỗ trợ Unicode
                        BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        var normalFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
                        var titleFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                        var headerFont=new iTextSharp.text.Font(baseFont, 15, iTextSharp.text.Font.BOLD);

                        Paragraph storeName = new Paragraph("Cửa hàng đồng hồ ALOWATCH ", headerFont);
                        storeName.Alignment = Element.ALIGN_CENTER;
                        document.Add(storeName);

                        document.Add(new Paragraph(" "));
                        // 📜 Thêm tiêu đề
                        Paragraph title = new Paragraph($"Hóa Đơn #{mahd}", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(title);

                        document.Add(new Paragraph(" "));  // Dòng trống

                        // 📑 Thêm thông tin khách hàng
                        document.Add(new Paragraph($"Tên khách hàng: {txtten.Text}", normalFont));
                        document.Add(new Paragraph($"Nhân viên: {txtnv.Text}", normalFont));
                        document.Add(new Paragraph($"Ngày tạo: {txtngay.Text}", normalFont));

                        document.Add(new Paragraph(" "));  // Dòng trống

                        // 📊 Thêm bảng chi tiết sản phẩm
                        PdfPTable table = new PdfPTable(4);
                        table.WidthPercentage = 100; // Chiếm toàn bộ chiều rộng trang

                        var tableFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
                        var tableHeaderFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);

                        // Header cột
                        table.AddCell(new PdfPCell(new Phrase("Sản phẩm", tableHeaderFont)));
                        table.AddCell(new PdfPCell(new Phrase("Số lượng", tableHeaderFont)));
                        table.AddCell(new PdfPCell(new Phrase("Đơn giá", tableHeaderFont)));
                        table.AddCell(new PdfPCell(new Phrase("Thành tiền", tableHeaderFont)));

                        // Duyệt qua từng dòng DataGridView để in chi tiết
                        foreach (DataGridViewRow row in hienthi.Rows)
                        {
                            if (row.Cells["Column1"].Value != null)
                            {
                                table.AddCell(new PdfPCell(new Phrase(row.Cells["Column2"].Value.ToString(), tableFont)));
                                table.AddCell(new PdfPCell(new Phrase(row.Cells["Column3"].Value.ToString(), tableFont)));
                                table.AddCell(new PdfPCell(new Phrase(row.Cells["Column4"].Value.ToString(), tableFont)));

                                decimal soluong = Convert.ToDecimal(row.Cells["Column3"].Value);
                                decimal dongia = Convert.ToDecimal(row.Cells["Column4"].Value);
                                decimal thanhtien = soluong * dongia;
                                table.AddCell(new PdfPCell(new Phrase(thanhtien.ToString(), tableFont)));
                            }
                        }

                        document.Add(table);
                        document.Add(new Paragraph($"Tổng tiền: {txtthanhtien.Text}", normalFont));
                        document.Add(new Paragraph($"Giảm giá: {txtgiamgia.Text}", normalFont));
                        document.Add(new Paragraph($"Thanh toán: {txtthanhtoan.Text}", normalFont));
                        document.Close();

                        MessageBox.Show($"File PDF đã được lưu: {saveFileDialog.FileName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể in hóa đơn: {ex.Message}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
