using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DONGHODEOTAY.Doituong;


namespace DONGHODEOTAY
{
    public partial class frmMain : Form
    {
        private Nguoidung nguoidung;
        private List<Form> openForms;

        public frmMain(Nguoidung nguoidung)
        {
            InitializeComponent();
            this.nguoidung = nguoidung;
            openForms = new List<Form>();
        }
        /*public void SetNguoidung(Doituong.Nguoidung user)
        {
            

        }*/
        private void CloseAllChildForms()
        {
            // Duyệt qua tất cả các Form con trong danh sách
            foreach (Form childForm in openForms)
            {
                if (childForm != null && !childForm.IsDisposed)
                {
                    childForm.Close(); // Đóng Form
                }
            }
            openForms.Clear(); // Xóa danh sách sau khi đóng
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btsanpham_Click(object sender, EventArgs e)
        {

            menuStripNhanvien.Visible = false;
            menuStripSanPham.Visible = true;
            CloseAllChildForms();

        }
        private void LoadFormIntoPanel(Form childForm)
        {
            // Đảm bảo chỉ có một Form trong Panel
            panelhienthi.Controls.Clear();

            // Đặt thuộc tính TopLevel = false
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            // Gắn Dock là None để không tự động thay đổi kích thước
            //childForm.Dock = DockStyle.None;
            childForm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền và tiêu đề

            // Điều chỉnh kích thước của Panel theo kích thước của Form
            panelhienthi.Width = childForm.Width;
            panelhienthi.Height = childForm.Height;
            // Thêm Form vào Panel
            panelhienthi.Controls.Add(childForm);
            childForm.Show();
        }
        private void panelhienthi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhanvien_Click(object sender, EventArgs e)
        {
            menuStripSanPham.Visible = false;
            menuStripNhanvien.Visible = true;
            CloseAllChildForms();

        }

        private void menuStripSanPham_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void danhmucsp_Click(object sender, EventArgs e)
        {
            frmSanPham sanpham = new frmSanPham();
            LoadFormIntoPanel(sanpham);
            openForms.Add(sanpham);
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            // Hiển thị lại Form đăng nhập
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();

            // Đóng Form hiện tại (Form chính)
            this.Close();
        }

        private void menuStripNhanvien_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void danhsachnv_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            LoadFormIntoPanel(frm);
            openForms.Add(frm);
        }

        private void taikhoanht_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            LoadFormIntoPanel(frm);
            openForms.Add(frm);
        }

        private void btbanhang_Click(object sender, EventArgs e)
        {

            frmBanHang formBanHang = new frmBanHang(nguoidung);
            formBanHang.Show();
            menuStripSanPham.Visible = false;
            menuStripNhanvien.Visible = false;
            CloseAllChildForms();
            
            LoadFormIntoPanel(formBanHang);
            openForms.Add(formBanHang);
        }
        // phân quyền 
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (nguoidung.Thuoctinh == "Nhân viên")
            {
                
                btnhanvien.Enabled = false;
            }
           
        }

        private void danhmucloaisp_Click(object sender, EventArgs e)
        {
            frmLoaiSP frm = new frmLoaiSP();
            LoadFormIntoPanel(frm);
            openForms.Add(frm);
        }

        private void bthoadon_Click(object sender, EventArgs e)
        {
            menuStripSanPham.Visible = false;
            menuStripNhanvien.Visible = false;
            frmHoaDon frm = new frmHoaDon();
            LoadFormIntoPanel(frm);
            openForms.Add(frm);
        }

        private void danhmucncc_Click(object sender, EventArgs e)
        {
            frmnhacc frm = new frmnhacc();
            LoadFormIntoPanel(frm);
            openForms.Add(frm);
        }

        private void btkhachhang_Click(object sender, EventArgs e)
        {
            menuStripSanPham.Visible = false;
            menuStripNhanvien.Visible = false;
            frmKhachHang frm = new frmKhachHang();
            LoadFormIntoPanel(frm);
            openForms.Add(frm);
        }
    }
}
