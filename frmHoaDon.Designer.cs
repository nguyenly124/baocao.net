namespace DONGHODEOTAY
{
    partial class frmHoaDon
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
            label1 = new Label();
            hienthi = new DataGridView();
            Mahd = new DataGridViewTextBoxColumn();
            ngaytao = new DataGridViewTextBoxColumn();
            nhanvien = new DataGridViewTextBoxColumn();
            khachhang = new DataGridViewTextBoxColumn();
            tienban = new DataGridViewTextBoxColumn();
            giamgia = new DataGridViewTextBoxColumn();
            thanhtoan = new DataGridViewTextBoxColumn();
            btct = new Button();
            btxoa = new Button();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(419, 27);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN BÁN HÀNG ";
            // 
            // hienthi
            // 
            hienthi.BackgroundColor = SystemColors.ButtonHighlight;
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Columns.AddRange(new DataGridViewColumn[] { Mahd, ngaytao, nhanvien, khachhang, tienban, giamgia, thanhtoan });
            hienthi.Location = new Point(61, 89);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(957, 428);
            hienthi.TabIndex = 1;
            hienthi.CellClick += hienthi_CellClick;
            // 
            // Mahd
            // 
            Mahd.HeaderText = "Mã hóa đơn ";
            Mahd.MinimumWidth = 6;
            Mahd.Name = "Mahd";
            Mahd.ReadOnly = true;
            Mahd.Width = 150;
            // 
            // ngaytao
            // 
            ngaytao.HeaderText = "Ngày tạo ";
            ngaytao.MinimumWidth = 6;
            ngaytao.Name = "ngaytao";
            ngaytao.Width = 125;
            // 
            // nhanvien
            // 
            nhanvien.HeaderText = "Nhân viên";
            nhanvien.MinimumWidth = 6;
            nhanvien.Name = "nhanvien";
            nhanvien.Width = 125;
            // 
            // khachhang
            // 
            khachhang.HeaderText = "Khách hàng ";
            khachhang.MinimumWidth = 6;
            khachhang.Name = "khachhang";
            khachhang.Width = 125;
            // 
            // tienban
            // 
            tienban.HeaderText = "Tiền bán ";
            tienban.MinimumWidth = 6;
            tienban.Name = "tienban";
            tienban.Width = 125;
            // 
            // giamgia
            // 
            giamgia.HeaderText = "Giảm giá ";
            giamgia.MinimumWidth = 6;
            giamgia.Name = "giamgia";
            giamgia.Width = 125;
            // 
            // thanhtoan
            // 
            thanhtoan.HeaderText = "Thanh toán ";
            thanhtoan.MinimumWidth = 6;
            thanhtoan.Name = "thanhtoan";
            thanhtoan.Width = 125;
            // 
            // btct
            // 
            btct.Location = new Point(670, 557);
            btct.Name = "btct";
            btct.Size = new Size(115, 34);
            btct.TabIndex = 2;
            btct.Text = "Xem chi tiết ";
            btct.UseVisualStyleBackColor = true;
            btct.Click += btct_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(903, 557);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(115, 34);
            btxoa.TabIndex = 3;
            btxoa.Text = "Xóa ";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1075, 667);
            Controls.Add(btxoa);
            Controls.Add(btct);
            Controls.Add(hienthi);
            Controls.Add(label1);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView hienthi;
        private DataGridViewTextBoxColumn Mahd;
        private DataGridViewTextBoxColumn ngaytao;
        private DataGridViewTextBoxColumn nhanvien;
        private DataGridViewTextBoxColumn khachhang;
        private DataGridViewTextBoxColumn tienban;
        private DataGridViewTextBoxColumn giamgia;
        private DataGridViewTextBoxColumn thanhtoan;
        private Button btct;
        private Button btxoa;
    }
}