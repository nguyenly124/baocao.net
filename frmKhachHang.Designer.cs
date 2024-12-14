namespace DONGHODEOTAY
{
    partial class frmKhachHang
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
            hienthikh = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtma = new TextBox();
            txtten = new TextBox();
            txtgioitinh = new TextBox();
            txtsodt = new TextBox();
            txtdiachi = new TextBox();
            txtluotmua = new TextBox();
            groupBox1 = new GroupBox();
            btthem = new Button();
            btsua = new Button();
            btxoa = new Button();
            hienthihoadon = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)hienthikh).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienthihoadon).BeginInit();
            SuspendLayout();
            // 
            // hienthikh
            // 
            hienthikh.BackgroundColor = SystemColors.ButtonHighlight;
            hienthikh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthikh.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            hienthikh.Location = new Point(12, 74);
            hienthikh.Name = "hienthikh";
            hienthikh.RowHeadersWidth = 51;
            hienthikh.Size = new Size(803, 359);
            hienthikh.TabIndex = 0;
            hienthikh.CellClick += hienthikh_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã khách hàng ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số điện thoại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Địa chỉ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Lượt mua";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 38);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(9, 45);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã KH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(9, 90);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(9, 135);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 180);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 5;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(852, 303);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 6;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(852, 359);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 7;
            label7.Text = "Lượt mua ";
            // 
            // txtma
            // 
            txtma.Location = new Point(129, 38);
            txtma.Name = "txtma";
            txtma.Size = new Size(235, 27);
            txtma.TabIndex = 8;
            // 
            // txtten
            // 
            txtten.Location = new Point(129, 83);
            txtten.Name = "txtten";
            txtten.Size = new Size(235, 27);
            txtten.TabIndex = 9;
            // 
            // txtgioitinh
            // 
            txtgioitinh.Location = new Point(129, 128);
            txtgioitinh.Name = "txtgioitinh";
            txtgioitinh.Size = new Size(235, 27);
            txtgioitinh.TabIndex = 10;
            // 
            // txtsodt
            // 
            txtsodt.Location = new Point(972, 247);
            txtsodt.Name = "txtsodt";
            txtsodt.Size = new Size(235, 27);
            txtsodt.TabIndex = 11;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(972, 300);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(235, 27);
            txtdiachi.TabIndex = 12;
            // 
            // txtluotmua
            // 
            txtluotmua.Location = new Point(972, 352);
            txtluotmua.Name = "txtluotmua";
            txtluotmua.Size = new Size(235, 27);
            txtluotmua.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtma);
            groupBox1.Controls.Add(txtgioitinh);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(843, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 359);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // btthem
            // 
            btthem.Location = new Point(844, 489);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 15;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(972, 489);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 16;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(1093, 489);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 17;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // hienthihoadon
            // 
            hienthihoadon.BackgroundColor = SystemColors.ButtonHighlight;
            hienthihoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthihoadon.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11 });
            hienthihoadon.Location = new Point(12, 451);
            hienthihoadon.Name = "hienthihoadon";
            hienthihoadon.RowHeadersWidth = 51;
            hienthihoadon.Size = new Size(803, 178);
            hienthihoadon.TabIndex = 18;
            hienthihoadon.CellClick += hienthihoadon_CellClick;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã hóa đơn ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Ngày tạo ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Tổng tiền ";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Giảm giá ";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Thanh toán ";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 125;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1232, 704);
            Controls.Add(hienthihoadon);
            Controls.Add(btxoa);
            Controls.Add(btsua);
            Controls.Add(btthem);
            Controls.Add(txtluotmua);
            Controls.Add(txtdiachi);
            Controls.Add(txtsodt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(hienthikh);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)hienthikh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hienthihoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView hienthikh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtma;
        private TextBox txtten;
        private TextBox txtgioitinh;
        private TextBox txtsodt;
        private TextBox txtdiachi;
        private TextBox txtluotmua;
        private GroupBox groupBox1;
        private Button btthem;
        private Button btsua;
        private Button btxoa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridView hienthihoadon;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}