namespace DONGHODEOTAY
{
    partial class frmthemkh
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
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtten = new TextBox();
            txtgt = new TextBox();
            txtsodt = new TextBox();
            txtdiachi = new TextBox();
            btthem = new Button();
            bthuy = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(223, 20);
            label7.Name = "label7";
            label7.Size = new Size(246, 31);
            label7.TabIndex = 6;
            label7.Text = "THÊM KHÁCH HÀNG ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 281);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 112);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 169);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 221);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // txtten
            // 
            txtten.Location = new Point(223, 112);
            txtten.Name = "txtten";
            txtten.Size = new Size(287, 27);
            txtten.TabIndex = 7;
            // 
            // txtgt
            // 
            txtgt.Location = new Point(223, 169);
            txtgt.Name = "txtgt";
            txtgt.Size = new Size(287, 27);
            txtgt.TabIndex = 8;
            // 
            // txtsodt
            // 
            txtsodt.Location = new Point(223, 221);
            txtsodt.Name = "txtsodt";
            txtsodt.Size = new Size(287, 27);
            txtsodt.TabIndex = 9;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(223, 281);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(287, 27);
            txtdiachi.TabIndex = 10;
            // 
            // btthem
            // 
            btthem.Location = new Point(223, 364);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 12;
            btthem.Text = "Thêm ";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // bthuy
            // 
            bthuy.Location = new Point(416, 364);
            bthuy.Name = "bthuy";
            bthuy.Size = new Size(94, 29);
            bthuy.TabIndex = 13;
            bthuy.Text = "Hủy";
            bthuy.UseVisualStyleBackColor = true;
            bthuy.Click += bthuy_Click;
            // 
            // frmthemkh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 425);
            Controls.Add(bthuy);
            Controls.Add(btthem);
            Controls.Add(txtdiachi);
            Controls.Add(txtsodt);
            Controls.Add(txtgt);
            Controls.Add(txtten);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmthemkh";
            Text = "frmthemkh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtten;
        private TextBox txtgt;
        private TextBox txtsodt;
        private TextBox txtdiachi;
        private Button btthem;
        private Button bthuy;
    }
}