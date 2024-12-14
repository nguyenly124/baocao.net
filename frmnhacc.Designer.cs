namespace DONGHODEOTAY
{
    partial class frmnhacc
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
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtten = new TextBox();
            txthang = new TextBox();
            txtsodt = new TextBox();
            txtdiachi = new TextBox();
            txtid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            hienthisp = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            btthem = new Button();
            btsua = new Button();
            btthoat = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienthisp).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(496, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 0;
            label1.Text = "NHÀ CUNG CẤP ";
            // 
            // hienthi
            // 
            hienthi.BackgroundColor = SystemColors.ButtonHighlight;
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            hienthi.Location = new Point(25, 101);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(625, 346);
            hienthi.TabIndex = 1;
            hienthi.CellClick += hienthi_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhà cung cấp ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Hãng ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số điện thoại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Địa chỉ ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(txthang);
            groupBox1.Controls.Add(txtsodt);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(675, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 304);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtten
            // 
            txtten.Location = new Point(194, 98);
            txtten.Name = "txtten";
            txtten.Size = new Size(217, 27);
            txtten.TabIndex = 10;
            // 
            // txthang
            // 
            txthang.Location = new Point(194, 142);
            txthang.Name = "txthang";
            txthang.Size = new Size(217, 27);
            txthang.TabIndex = 9;
            // 
            // txtsodt
            // 
            txtsodt.Location = new Point(194, 191);
            txtsodt.Name = "txtsodt";
            txtsodt.Size = new Size(217, 27);
            txtsodt.TabIndex = 8;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(194, 238);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(217, 27);
            txtdiachi.TabIndex = 6;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(194, 50);
            txtid.Name = "txtid";
            txtid.Size = new Size(217, 27);
            txtid.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(24, 241);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(24, 191);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 3;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 145);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Hãng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 50);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // hienthisp
            // 
            hienthisp.BackgroundColor = SystemColors.ButtonHighlight;
            hienthisp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthisp.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9 });
            hienthisp.Enabled = false;
            hienthisp.Location = new Point(25, 473);
            hienthisp.Name = "hienthisp";
            hienthisp.RowHeadersWidth = 51;
            hienthisp.Size = new Size(625, 159);
            hienthisp.TabIndex = 3;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mã sản phẩm";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tên sản phẩm ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Số lượng ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Giá bán ";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // btthem
            // 
            btthem.Location = new Point(21, 44);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 4;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(191, 44);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 5;
            btsua.Text = "Sửa ";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(356, 44);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 6;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btthoat);
            groupBox2.Controls.Add(btthem);
            groupBox2.Controls.Add(btsua);
            groupBox2.Location = new Point(678, 481);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 88);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // frmnhacc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1179, 677);
            Controls.Add(groupBox2);
            Controls.Add(hienthisp);
            Controls.Add(groupBox1);
            Controls.Add(hienthi);
            Controls.Add(label1);
            Name = "frmnhacc";
            Text = "frmnhacc";
            Load += frmnhacc_Load;
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hienthisp).EndInit();
            groupBox2.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtten;
        private TextBox txthang;
        private TextBox txtsodt;
        private TextBox txtdiachi;
        private TextBox txtid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView hienthisp;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button btthem;
        private Button btsua;
        private Button btthoat;
        private GroupBox groupBox2;
    }
}