namespace DONGHODEOTAY
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtmota = new RichTextBox();
            txtloaisp = new ComboBox();
            txtnhacc = new ComboBox();
            txtgiaban = new TextBox();
            txtgianhap = new TextBox();
            txtsoluong = new TextBox();
            txtten = new TextBox();
            txtma = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btthoat = new Button();
            btxoa = new Button();
            btsua = new Button();
            btthem = new Button();
            groupBox3 = new GroupBox();
            bttimkiem = new Button();
            txttimkiem = new TextBox();
            label8 = new Label();
            hienthi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtmota);
            groupBox1.Controls.Add(txtloaisp);
            groupBox1.Controls.Add(txtnhacc);
            groupBox1.Controls.Add(txtgiaban);
            groupBox1.Controls.Add(txtgianhap);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(txtma);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 662);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 413);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 15;
            label9.Text = "Mô tả ";
            // 
            // txtmota
            // 
            txtmota.Location = new Point(25, 436);
            txtmota.Name = "txtmota";
            txtmota.Size = new Size(284, 210);
            txtmota.TabIndex = 14;
            txtmota.Text = "";
            // 
            // txtloaisp
            // 
            txtloaisp.DropDownStyle = ComboBoxStyle.DropDownList;
            txtloaisp.FormattingEnabled = true;
            txtloaisp.Location = new Point(24, 289);
            txtloaisp.Name = "txtloaisp";
            txtloaisp.Size = new Size(283, 28);
            txtloaisp.TabIndex = 13;
            // 
            // txtnhacc
            // 
            txtnhacc.DropDownStyle = ComboBoxStyle.DropDownList;
            txtnhacc.FormattingEnabled = true;
            txtnhacc.Location = new Point(25, 372);
            txtnhacc.Name = "txtnhacc";
            txtnhacc.Size = new Size(283, 28);
            txtnhacc.TabIndex = 12;
            txtnhacc.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtgiaban
            // 
            txtgiaban.Location = new Point(143, 205);
            txtgiaban.Name = "txtgiaban";
            txtgiaban.Size = new Size(165, 27);
            txtgiaban.TabIndex = 11;
            // 
            // txtgianhap
            // 
            txtgianhap.Location = new Point(143, 162);
            txtgianhap.Name = "txtgianhap";
            txtgianhap.Size = new Size(165, 27);
            txtgianhap.TabIndex = 10;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(143, 115);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(165, 27);
            txtsoluong.TabIndex = 9;
            // 
            // txtten
            // 
            txtten.Location = new Point(143, 73);
            txtten.Name = "txtten";
            txtten.Size = new Size(165, 27);
            txtten.TabIndex = 8;
            // 
            // txtma
            // 
            txtma.Location = new Point(143, 26);
            txtma.Name = "txtma";
            txtma.ReadOnly = true;
            txtma.Size = new Size(165, 27);
            txtma.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 337);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 6;
            label7.Text = "Nhà cung cấp ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 205);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá bán ";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 257);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 4;
            label5.Text = "Loại sản phẩm ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 162);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Giá nhập ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 115);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 72);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btthoat);
            groupBox2.Controls.Add(btxoa);
            groupBox2.Controls.Add(btsua);
            groupBox2.Controls.Add(btthem);
            groupBox2.Location = new Point(358, 631);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(881, 84);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btthoat
            // 
            btthoat.Location = new Point(740, 39);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 3;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(531, 39);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 2;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(281, 39);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 1;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // btthem
            // 
            btthem.Location = new Point(50, 38);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 0;
            btthem.Text = "Thêm";
            btthem.UseCompatibleTextRendering = true;
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bttimkiem);
            groupBox3.Controls.Add(txttimkiem);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(hienthi);
            groupBox3.Location = new Point(358, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(906, 568);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu ";
            // 
            // bttimkiem
            // 
            bttimkiem.BackgroundImage = (Image)resources.GetObject("bttimkiem.BackgroundImage");
            bttimkiem.BackgroundImageLayout = ImageLayout.Center;
            bttimkiem.Location = new Point(581, 19);
            bttimkiem.Name = "bttimkiem";
            bttimkiem.Size = new Size(58, 44);
            bttimkiem.TabIndex = 3;
            bttimkiem.UseVisualStyleBackColor = true;
            bttimkiem.Click += bttimkiem_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(123, 28);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(426, 27);
            txttimkiem.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 30);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 1;
            label8.Text = "Tìm kiếm ";
            // 
            // hienthi
            // 
            hienthi.Anchor = AnchorStyles.None;
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            hienthi.GridColor = SystemColors.ScrollBar;
            hienthi.Location = new Point(11, 99);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(889, 442);
            hienthi.TabIndex = 0;
            hienthi.CellClick += hienthi_CellClick;
            hienthi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sản phẩm ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá nhập ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Giá bán ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Loại sản phẩm ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 110;
            // 
            // Column7
            // 
            Column7.HeaderText = "Nhà cung cấp ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Mô tả ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(449, 9);
            label10.Name = "label10";
            label10.Size = new Size(305, 38);
            label10.TabIndex = 3;
            label10.Text = "QUẢN LÝ SẢN PHẨM ";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1282, 753);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView hienthi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtgianhap;
        private TextBox txtsoluong;
        private TextBox txtten;
        private TextBox txtma;
        private ComboBox txtnhacc;
        private TextBox txtgiaban;
        private ComboBox txtloaisp;
        private Button bttimkiem;
        private TextBox txttimkiem;
        private Label label8;
        private Label label9;
        private RichTextBox txtmota;
        private Button btxoa;
        private Button btsua;
        private Button btthem;
        private Button btthoat;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label10;
    }
}