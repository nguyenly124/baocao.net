namespace DONGHODEOTAY
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panel1 = new Panel();
            btbanhang = new Button();
            bthoadon = new Button();
            btkhachhang = new Button();
            btnhanvien = new Button();
            btsanpham = new Button();
            pictureBox1 = new PictureBox();
            panelhienthi = new Panel();
            menuStripSanPham = new MenuStrip();
            danhmucsp = new ToolStripMenuItem();
            danhmucncc = new ToolStripMenuItem();
            danhmucloaisp = new ToolStripMenuItem();
            menuStripNhanvien = new MenuStrip();
            danhsachnv = new ToolStripMenuItem();
            taikhoanht = new ToolStripMenuItem();
            btdangxuat = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStripSanPham.SuspendLayout();
            menuStripNhanvien.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btbanhang);
            panel1.Controls.Add(bthoadon);
            panel1.Controls.Add(btkhachhang);
            panel1.Controls.Add(btnhanvien);
            panel1.Controls.Add(btsanpham);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 800);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btbanhang
            // 
            btbanhang.BackColor = Color.Peru;
            btbanhang.BackgroundImage = Properties.Resources.shoppingcart_77905;
            btbanhang.BackgroundImageLayout = ImageLayout.None;
            btbanhang.FlatAppearance.BorderSize = 0;
            btbanhang.FlatStyle = FlatStyle.Flat;
            btbanhang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btbanhang.ForeColor = Color.White;
            btbanhang.Location = new Point(28, 676);
            btbanhang.Margin = new Padding(2, 0, 0, 0);
            btbanhang.Name = "btbanhang";
            btbanhang.Size = new Size(217, 49);
            btbanhang.TabIndex = 6;
            btbanhang.Text = "Bán hàng ";
            btbanhang.UseVisualStyleBackColor = false;
            btbanhang.Click += btbanhang_Click;
            // 
            // bthoadon
            // 
            bthoadon.BackColor = Color.Peru;
            bthoadon.BackgroundImage = Properties.Resources.invoice_document_bill_delivery_note_icon_225179;
            bthoadon.BackgroundImageLayout = ImageLayout.None;
            bthoadon.FlatAppearance.BorderSize = 0;
            bthoadon.FlatStyle = FlatStyle.Flat;
            bthoadon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bthoadon.ForeColor = Color.White;
            bthoadon.Location = new Point(28, 568);
            bthoadon.Margin = new Padding(2, 0, 0, 0);
            bthoadon.Name = "bthoadon";
            bthoadon.Size = new Size(217, 49);
            bthoadon.TabIndex = 4;
            bthoadon.Text = "Hóa đơn";
            bthoadon.UseVisualStyleBackColor = false;
            bthoadon.Click += bthoadon_Click;
            // 
            // btkhachhang
            // 
            btkhachhang.BackColor = Color.Peru;
            btkhachhang.BackgroundImage = Properties.Resources.consultant_manager_adviser_deals_people_advisor_financial_banker_accountant_icon_258632;
            btkhachhang.BackgroundImageLayout = ImageLayout.None;
            btkhachhang.FlatAppearance.BorderSize = 0;
            btkhachhang.FlatStyle = FlatStyle.Flat;
            btkhachhang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btkhachhang.ForeColor = Color.White;
            btkhachhang.Location = new Point(28, 458);
            btkhachhang.Margin = new Padding(2, 0, 0, 0);
            btkhachhang.Name = "btkhachhang";
            btkhachhang.Size = new Size(217, 49);
            btkhachhang.TabIndex = 3;
            btkhachhang.Text = "Khách hàng ";
            btkhachhang.UseVisualStyleBackColor = false;
            btkhachhang.Click += btkhachhang_Click;
            // 
            // btnhanvien
            // 
            btnhanvien.BackColor = Color.Peru;
            btnhanvien.BackgroundImage = Properties.Resources.employee_account_business_time_clock_icon_124657;
            btnhanvien.BackgroundImageLayout = ImageLayout.None;
            btnhanvien.FlatAppearance.BorderSize = 0;
            btnhanvien.FlatStyle = FlatStyle.Flat;
            btnhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnhanvien.ForeColor = Color.White;
            btnhanvien.Location = new Point(28, 352);
            btnhanvien.Margin = new Padding(2, 0, 0, 0);
            btnhanvien.Name = "btnhanvien";
            btnhanvien.Size = new Size(217, 49);
            btnhanvien.TabIndex = 2;
            btnhanvien.Text = "Nhân viên ";
            btnhanvien.UseVisualStyleBackColor = false;
            btnhanvien.Click += btnhanvien_Click;
            // 
            // btsanpham
            // 
            btsanpham.BackColor = Color.Peru;
            btsanpham.BackgroundImage = Properties.Resources.clock_hour_watch_time_icon_1869762;
            btsanpham.BackgroundImageLayout = ImageLayout.None;
            btsanpham.FlatAppearance.BorderSize = 0;
            btsanpham.FlatStyle = FlatStyle.Flat;
            btsanpham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btsanpham.ForeColor = Color.White;
            btsanpham.Location = new Point(28, 246);
            btsanpham.Margin = new Padding(2, 0, 0, 0);
            btsanpham.Name = "btsanpham";
            btsanpham.Size = new Size(217, 49);
            btsanpham.TabIndex = 1;
            btsanpham.Text = "Sản phẩm";
            btsanpham.UseVisualStyleBackColor = false;
            btsanpham.Click += btsanpham_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(28, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 187);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelhienthi
            // 
            panelhienthi.Location = new Point(281, 60);
            panelhienthi.Name = "panelhienthi";
            panelhienthi.Size = new Size(1189, 690);
            panelhienthi.TabIndex = 1;
            panelhienthi.Paint += panelhienthi_Paint;
            // 
            // menuStripSanPham
            // 
            menuStripSanPham.Dock = DockStyle.None;
            menuStripSanPham.ImageScalingSize = new Size(20, 20);
            menuStripSanPham.Items.AddRange(new ToolStripItem[] { danhmucsp, danhmucncc, danhmucloaisp });
            menuStripSanPham.Location = new Point(296, 26);
            menuStripSanPham.Name = "menuStripSanPham";
            menuStripSanPham.Size = new Size(506, 28);
            menuStripSanPham.TabIndex = 2;
            menuStripSanPham.Text = "menuStrip1";
            menuStripSanPham.Visible = false;
            menuStripSanPham.ItemClicked += menuStripSanPham_ItemClicked;
            // 
            // danhmucsp
            // 
            danhmucsp.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            danhmucsp.Name = "danhmucsp";
            danhmucsp.Size = new Size(173, 24);
            danhmucsp.Text = "Danh mục sản phẩm ";
            danhmucsp.Click += danhmucsp_Click;
            // 
            // danhmucncc
            // 
            danhmucncc.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            danhmucncc.Name = "danhmucncc";
            danhmucncc.Size = new Size(193, 24);
            danhmucncc.Text = "Danh mục nhà cung cấp";
            danhmucncc.Click += danhmucncc_Click;
            // 
            // danhmucloaisp
            // 
            danhmucloaisp.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            danhmucloaisp.Name = "danhmucloaisp";
            danhmucloaisp.Size = new Size(132, 24);
            danhmucloaisp.Text = "Loại sản phẩm ";
            danhmucloaisp.Click += danhmucloaisp_Click;
            // 
            // menuStripNhanvien
            // 
            menuStripNhanvien.Dock = DockStyle.None;
            menuStripNhanvien.ImageScalingSize = new Size(20, 20);
            menuStripNhanvien.Items.AddRange(new ToolStripItem[] { danhsachnv, taikhoanht });
            menuStripNhanvien.Location = new Point(293, 26);
            menuStripNhanvien.Name = "menuStripNhanvien";
            menuStripNhanvien.Size = new Size(344, 28);
            menuStripNhanvien.TabIndex = 3;
            menuStripNhanvien.Text = "menuStripNhanVien";
            menuStripNhanvien.Visible = false;
            menuStripNhanvien.ItemClicked += menuStripNhanvien_ItemClicked;
            // 
            // danhsachnv
            // 
            danhsachnv.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            danhsachnv.Name = "danhsachnv";
            danhsachnv.Size = new Size(171, 24);
            danhsachnv.Text = "Danh sách nhân viên";
            danhsachnv.Click += danhsachnv_Click;
            // 
            // taikhoanht
            // 
            taikhoanht.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            taikhoanht.Name = "taikhoanht";
            taikhoanht.Size = new Size(165, 24);
            taikhoanht.Text = "Tài khoản hệ thống ";
            taikhoanht.Click += taikhoanht_Click;
            // 
            // btdangxuat
            // 
            btdangxuat.Image = Properties.Resources.user_account_off_door_arrow_leave_ui_exit_logout_icon_210826;
            btdangxuat.ImageAlign = ContentAlignment.MiddleRight;
            btdangxuat.Location = new Point(1415, 4);
            btdangxuat.Name = "btdangxuat";
            btdangxuat.Size = new Size(65, 50);
            btdangxuat.TabIndex = 4;
            btdangxuat.UseVisualStyleBackColor = true;
            btdangxuat.Click += btdangxuat_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1482, 753);
            Controls.Add(btdangxuat);
            Controls.Add(panelhienthi);
            Controls.Add(panel1);
            Controls.Add(menuStripNhanvien);
            Controls.Add(menuStripSanPham);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripNhanvien;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ALOWATCH";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStripSanPham.ResumeLayout(false);
            menuStripSanPham.PerformLayout();
            menuStripNhanvien.ResumeLayout(false);
            menuStripNhanvien.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btsanpham;
        private Button btnhanvien;
        private Panel panelhienthi;
        private Button btbanhang;
        private Button bthoadon;
        private Button btkhachhang;
        private MenuStrip menuStripSanPham;
        private ToolStripMenuItem danhmucsp;
        private ToolStripMenuItem danhmucncc;
        private ToolStripMenuItem danhmucloaisp;
        private MenuStrip menuStripNhanvien;
        private ToolStripMenuItem danhsachnv;
        private ToolStripMenuItem taikhoanht;
        private Button btdangxuat;
    }
}