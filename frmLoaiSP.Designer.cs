namespace DONGHODEOTAY
{
    partial class frmLoaiSP
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtma = new TextBox();
            txtten = new TextBox();
            txtsoluong = new TextBox();
            groupBox1 = new GroupBox();
            btthem = new Button();
            btsua = new Button();
            btthoat = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 22);
            label1.Name = "label1";
            label1.Size = new Size(334, 31);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC LOẠI SẢN PHẨM ";
            // 
            // hienthi
            // 
            hienthi.BackgroundColor = SystemColors.ButtonHighlight;
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            hienthi.Location = new Point(508, 93);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(546, 429);
            hienthi.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã loại sản phẩm ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên loại sản phẩm ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(30, 46);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 2;
            label2.Text = "Mã loại ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(30, 94);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 3;
            label3.Text = "Tên ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(30, 146);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 4;
            label4.Text = "Số lượng ";
            // 
            // txtma
            // 
            txtma.Location = new Point(142, 42);
            txtma.Name = "txtma";
            txtma.Size = new Size(288, 27);
            txtma.TabIndex = 5;
            // 
            // txtten
            // 
            txtten.Location = new Point(142, 94);
            txtten.Name = "txtten";
            txtten.Size = new Size(288, 27);
            txtten.TabIndex = 6;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(142, 142);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(288, 27);
            txtsoluong.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtma);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(31, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 200);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // btthem
            // 
            btthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btthem.Location = new Point(524, 550);
            btthem.Name = "btthem";
            btthem.Size = new Size(105, 32);
            btthem.TabIndex = 10;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            btsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btsua.Location = new Point(712, 550);
            btsua.Name = "btsua";
            btsua.Size = new Size(114, 31);
            btsua.TabIndex = 11;
            btsua.Text = "Sửa ";
            btsua.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            btthoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btthoat.Location = new Point(894, 552);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 12;
            btthoat.Text = "Thoát ";
            btthoat.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(31, 338);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(457, 184);
            dataGridView2.TabIndex = 9;
            // 
            // frmLoaiSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1066, 592);
            Controls.Add(dataGridView2);
            Controls.Add(btthoat);
            Controls.Add(btsua);
            Controls.Add(btthem);
            Controls.Add(groupBox1);
            Controls.Add(hienthi);
            Controls.Add(label1);
            Name = "frmLoaiSP";
            Text = "frmLoaiSP";
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView hienthi;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtma;
        private TextBox txtten;
        private TextBox txtsoluong;
        private GroupBox groupBox1;
        private Button btthem;
        private Button btsua;
        private Button btthoat;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView dataGridView2;
    }
}