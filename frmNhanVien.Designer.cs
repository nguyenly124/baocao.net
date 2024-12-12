namespace DONGHODEOTAY
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            hienthi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtSodt = new TextBox();
            txtDiachi = new TextBox();
            txtTennv = new TextBox();
            txtManv = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btxoa = new Button();
            btsua = new Button();
            bthem = new Button();
            groupBox3 = new GroupBox();
            bttimkiem = new Button();
            txttimkiem = new TextBox();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // hienthi
            // 
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            hienthi.Location = new Point(18, 82);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 30;
            hienthi.Size = new Size(620, 453);
            hienthi.TabIndex = 0;
            hienthi.CellClick += hienthi_CellClick;
            hienthi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhân viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Địa chỉ ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số điện thoại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSodt);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtTennv);
            groupBox1.Controls.Add(txtManv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(5, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 460);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // txtSodt
            // 
            txtSodt.Location = new Point(90, 394);
            txtSodt.Name = "txtSodt";
            txtSodt.Size = new Size(337, 27);
            txtSodt.TabIndex = 7;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(90, 300);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(337, 27);
            txtDiachi.TabIndex = 6;
            // 
            // txtTennv
            // 
            txtTennv.Location = new Point(90, 212);
            txtTennv.Name = "txtTennv";
            txtTennv.Size = new Size(337, 27);
            txtTennv.TabIndex = 5;
            // 
            // txtManv
            // 
            txtManv.Location = new Point(90, 102);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(337, 27);
            txtManv.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 361);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 3;
            label5.Text = "Số điện thoại ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 261);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 163);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên nhân viên";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 62);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btxoa);
            groupBox2.Controls.Add(btsua);
            groupBox2.Controls.Add(bthem);
            groupBox2.Location = new Point(5, 553);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 88);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng ";
            // 
            // btxoa
            // 
            btxoa.Location = new Point(333, 40);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 2;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(163, 40);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 1;
            btsua.Text = "Sửa ";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // bthem
            // 
            bthem.Location = new Point(23, 40);
            bthem.Name = "bthem";
            bthem.Size = new Size(94, 29);
            bthem.TabIndex = 0;
            bthem.Text = "Thêm";
            bthem.UseVisualStyleBackColor = true;
            bthem.Click += bthem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bttimkiem);
            groupBox3.Controls.Add(txttimkiem);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(hienthi);
            groupBox3.Location = new Point(509, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(651, 554);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu ";
            // 
            // bttimkiem
            // 
            bttimkiem.BackgroundImage = (Image)resources.GetObject("bttimkiem.BackgroundImage");
            bttimkiem.BackgroundImageLayout = ImageLayout.Stretch;
            bttimkiem.Location = new Point(548, 30);
            bttimkiem.Name = "bttimkiem";
            bttimkiem.Size = new Size(35, 35);
            bttimkiem.TabIndex = 3;
            bttimkiem.UseVisualStyleBackColor = true;
            bttimkiem.Click += bttimkiem_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(114, 34);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(416, 27);
            txttimkiem.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(418, 19);
            label6.Name = "label6";
            label6.Size = new Size(312, 38);
            label6.TabIndex = 4;
            label6.Text = "QUẢN LÝ NHÂN VIÊN ";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1182, 653);
            Controls.Add(label6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView hienthi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox txttimkiem;
        private Button btxoa;
        private Button btsua;
        private Button bthem;
        private Button bttimkiem;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSodt;
        private TextBox txtDiachi;
        private TextBox txtTennv;
        private TextBox txtManv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label6;
    }
}