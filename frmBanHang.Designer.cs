namespace DONGHODEOTAY
{
    partial class frmBanHang
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
            groupBox1 = new GroupBox();
            btcapnhat = new Button();
            btthem = new Button();
            txtgia = new TextBox();
            txtsoluong = new NumericUpDown();
            txtma = new ComboBox();
            txtten = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            hienthihoadon = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txttongtien = new TextBox();
            bttaohd = new Button();
            btthoat = new Button();
            label6 = new Label();
            txtgiamgia = new TextBox();
            label7 = new Label();
            txtthanhtoan = new TextBox();
            groupBox2 = new GroupBox();
            btthemkh = new Button();
            txttenkh = new TextBox();
            txtdiachi = new TextBox();
            txtsodt = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtsoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hienthihoadon).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btcapnhat);
            groupBox1.Controls.Add(btthem);
            groupBox1.Controls.Add(txtgia);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(txtma);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // btcapnhat
            // 
            btcapnhat.BackgroundImage = Properties.Resources.vcsupdaterequired_93493;
            btcapnhat.BackgroundImageLayout = ImageLayout.Center;
            btcapnhat.Location = new Point(331, 281);
            btcapnhat.Name = "btcapnhat";
            btcapnhat.Size = new Size(48, 48);
            btcapnhat.TabIndex = 9;
            btcapnhat.UseVisualStyleBackColor = true;
            btcapnhat.Click += btcapnhat_Click;
            // 
            // btthem
            // 
            btthem.BackgroundImage = Properties.Resources._1486564411_checkmark_81522;
            btthem.BackgroundImageLayout = ImageLayout.Center;
            btthem.Location = new Point(243, 281);
            btthem.Name = "btthem";
            btthem.Size = new Size(48, 48);
            btthem.TabIndex = 8;
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // txtgia
            // 
            txtgia.Location = new Point(160, 229);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(219, 27);
            txtgia.TabIndex = 7;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(160, 167);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(217, 27);
            txtsoluong.TabIndex = 6;
            // 
            // txtma
            // 
            txtma.FormattingEnabled = true;
            txtma.Location = new Point(160, 40);
            txtma.Name = "txtma";
            txtma.Size = new Size(217, 28);
            txtma.TabIndex = 5;
            txtma.SelectedIndexChanged += txtma_SelectedIndexChanged;
            // 
            // txtten
            // 
            txtten.FormattingEnabled = true;
            txtten.Location = new Point(160, 105);
            txtten.Name = "txtten";
            txtten.Size = new Size(219, 28);
            txtten.TabIndex = 4;
            txtten.SelectedIndexChanged += txtten_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 232);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(24, 43);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã sản phẩm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 169);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Số lượng ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 108);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm ";
            // 
            // hienthihoadon
            // 
            hienthihoadon.BackgroundColor = SystemColors.ButtonHighlight;
            hienthihoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthihoadon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            hienthihoadon.Location = new Point(448, 25);
            hienthihoadon.Name = "hienthihoadon";
            hienthihoadon.RowHeadersWidth = 51;
            hienthihoadon.Size = new Size(709, 339);
            hienthihoadon.TabIndex = 1;
            hienthihoadon.CellClick += hienthihoadon_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sản phẩm ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thành tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(481, 395);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 2;
            label5.Text = "Tổng tiền ";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(629, 396);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(188, 27);
            txttongtien.TabIndex = 3;
            // 
            // bttaohd
            // 
            bttaohd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttaohd.Location = new Point(774, 594);
            bttaohd.Name = "bttaohd";
            bttaohd.Size = new Size(106, 29);
            bttaohd.TabIndex = 4;
            bttaohd.Text = "Tạo hóa đơn ";
            bttaohd.UseVisualStyleBackColor = true;
            bttaohd.Click += btthanhtoan_Click;
            // 
            // btthoat
            // 
            btthoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btthoat.Location = new Point(985, 594);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(106, 29);
            btthoat.TabIndex = 5;
            btthoat.Text = "Thoát ";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(861, 398);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 6;
            label6.Text = "Giảm giá ";
            // 
            // txtgiamgia
            // 
            txtgiamgia.Location = new Point(970, 393);
            txtgiamgia.Name = "txtgiamgia";
            txtgiamgia.Size = new Size(121, 27);
            txtgiamgia.TabIndex = 7;
            txtgiamgia.TextChanged += txtgiamgia_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(481, 457);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 8;
            label7.Text = "Thanh toán ";
            // 
            // txtthanhtoan
            // 
            txtthanhtoan.Location = new Point(629, 457);
            txtthanhtoan.Name = "txtthanhtoan";
            txtthanhtoan.Size = new Size(251, 27);
            txtthanhtoan.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btthemkh);
            groupBox2.Controls.Add(txttenkh);
            groupBox2.Controls.Add(txtdiachi);
            groupBox2.Controls.Add(txtsodt);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(15, 383);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 256);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng ";
            // 
            // btthemkh
            // 
            btthemkh.Location = new Point(240, 209);
            btthemkh.Name = "btthemkh";
            btthemkh.Size = new Size(144, 31);
            btthemkh.TabIndex = 8;
            btthemkh.Text = "Thêm khách hàng";
            btthemkh.UseVisualStyleBackColor = true;
            btthemkh.Visible = false;
            btthemkh.Click += btthemkh_Click;
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(160, 55);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(227, 27);
            txttenkh.TabIndex = 7;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(160, 155);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(221, 27);
            txtdiachi.TabIndex = 6;
            // 
            // txtsodt
            // 
            txtsodt.Location = new Point(160, 101);
            txtsodt.Name = "txtsodt";
            txtsodt.Size = new Size(224, 27);
            txtsodt.TabIndex = 5;
            txtsodt.TextChanged += txtsodt_TextChanged;
            txtsodt.Leave += txtsodt_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 155);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 2;
            label10.Text = "Địa chỉ ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 108);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 1;
            label9.Text = "Số điện thoại ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 58);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 0;
            label8.Text = "Tên khách hàng";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1162, 665);
            Controls.Add(groupBox2);
            Controls.Add(txtthanhtoan);
            Controls.Add(label7);
            Controls.Add(txtgiamgia);
            Controls.Add(label6);
            Controls.Add(btthoat);
            Controls.Add(bttaohd);
            Controls.Add(txttongtien);
            Controls.Add(label5);
            Controls.Add(hienthihoadon);
            Controls.Add(groupBox1);
            Name = "frmBanHang";
            Text = "frmBanHang";
            Load += frmBanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtsoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)hienthihoadon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox txtten;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtgia;
        private NumericUpDown txtsoluong;
        private ComboBox txtma;
        private Button btthem;
        private DataGridView hienthihoadon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label5;
        private TextBox txttongtien;
        private Button bttaohd;
        private Button btthoat;
        private DataGridViewTextBoxColumn Column5;
        private Button btcapnhat;
        private Label label6;
        private TextBox txtgiamgia;
        private Label label7;
        private TextBox txtthanhtoan;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtdiachi;
        private TextBox txtsodt;
        private Button btthemkh;
        private TextBox txttenkh;
    }
}