namespace QuanLyBanTruyen
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            label1 = new Label();
            txtMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            label2 = new Label();
            txtNhapLai = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 133);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 11;
            label1.Text = "Mật khẩu cũ:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhau.Location = new Point(234, 133);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(303, 27);
            txtMatKhau.TabIndex = 12;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhauMoi.Location = new Point(234, 188);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(303, 27);
            txtMatKhauMoi.TabIndex = 14;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 188);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 13;
            label2.Text = "Mật khẩu mới:";
            // 
            // txtNhapLai
            // 
            txtNhapLai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNhapLai.Location = new Point(234, 243);
            txtNhapLai.Name = "txtNhapLai";
            txtNhapLai.Size = new Size(303, 27);
            txtNhapLai.TabIndex = 16;
            txtNhapLai.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(56, 246);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 15;
            label4.Text = "Nhập lại mật khẩu:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(408, 304);
            button1.Name = "button1";
            button1.Size = new Size(129, 28);
            button1.TabIndex = 17;
            button1.Text = "Đổi mật khẩu";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(51, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 251);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(27, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(545, 310);
            panel3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(6, 12);
            label3.Name = "label3";
            label3.Size = new Size(274, 46);
            label3.TabIndex = 10;
            label3.Text = "ĐỔI MẬT KHẨU";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(50, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 68);
            panel2.TabIndex = 19;
            // 
            // FrmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 372);
            Controls.Add(panel2);
            Controls.Add(txtNhapLai);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label2);
            Controls.Add(txtMatKhau);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FrmDoiMatKhau";
            Text = "FrmDoiMatKhau";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtMatKhau;
        private TextBox txtMatKhauMoi;
        private Label label2;
        private TextBox txtNhapLai;
        private Label label4;
        private Button button1;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
    }
}