namespace DONGHODEOTAY
{
    partial class frmTaiKhoan
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtten = new TextBox();
            txtmatkhau = new TextBox();
            txttaikhoan = new ComboBox();
            btthem = new Button();
            btsua = new Button();
            btxoa = new Button();
            btthoat = new Button();
            label5 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 31);
            label1.TabIndex = 0;
            label1.Text = "TÀI KHOẢN HỆ THỐNG ";
            label1.Click += label1_Click;
            // 
            // hienthi
            // 
            hienthi.BackgroundColor = SystemColors.ButtonHighlight;
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            hienthi.Location = new Point(240, 84);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(603, 321);
            hienthi.TabIndex = 1;
            hienthi.CellClick += hienthi_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên đăng nhập";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mật khẩu";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Loại tài khoản ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(34, 158);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(34, 250);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(33, 340);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 4;
            label4.Text = "Loại tài khoản ";
            label4.Click += label4_Click;
            // 
            // txtten
            // 
            txtten.Location = new Point(34, 195);
            txtten.Name = "txtten";
            txtten.Size = new Size(168, 27);
            txtten.TabIndex = 5;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(33, 282);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(169, 27);
            txtmatkhau.TabIndex = 6;
            // 
            // txttaikhoan
            // 
            txttaikhoan.FormattingEnabled = true;
            txttaikhoan.Items.AddRange(new object[] { "Quản lý ", "Nhân viên " });
            txttaikhoan.Location = new Point(33, 372);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(169, 28);
            txttaikhoan.TabIndex = 7;
            // 
            // btthem
            // 
            btthem.Location = new Point(240, 441);
            btthem.Name = "btthem";
            btthem.Size = new Size(99, 29);
            btthem.TabIndex = 8;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(414, 441);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 9;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(580, 441);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 10;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(749, 441);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 11;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 84);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 12;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(34, 117);
            txtID.Name = "txtID";
            txtID.Size = new Size(168, 27);
            txtID.TabIndex = 13;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(867, 495);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(btthoat);
            Controls.Add(btxoa);
            Controls.Add(btsua);
            Controls.Add(btthem);
            Controls.Add(txttaikhoan);
            Controls.Add(txtmatkhau);
            Controls.Add(txtten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(hienthi);
            Controls.Add(label1);
            Name = "frmTaiKhoan";
            Text = "frmTaiKhoan";
            Load += frmTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView hienthi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtten;
        private TextBox txtmatkhau;
        private ComboBox txttaikhoan;
        private Button btthem;
        private Button btsua;
        private Button btxoa;
        private Button btthoat;
        private Label label5;
        private TextBox txtID;
    }
}