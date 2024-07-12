namespace QuanLyBanTruyen
{
    partial class FrmEmployeeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeDetail));
            lblTieuDe = new Label();
            panel3 = new Panel();
            btnShow = new Button();
            btnHide = new Button();
            btnBoQua = new Button();
            btnDongY = new Button();
            label8 = new Label();
            label6 = new Label();
            cbbGioiTinh = new ComboBox();
            txtAdress = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(43, 24);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(318, 46);
            lblTieuDe.TabIndex = 7;
            lblTieuDe.Text = "THÊM NHÂN VIÊN";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnShow);
            panel3.Controls.Add(btnHide);
            panel3.Controls.Add(btnBoQua);
            panel3.Controls.Add(btnDongY);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(cbbGioiTinh);
            panel3.Controls.Add(txtAdress);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(25, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(565, 363);
            panel3.TabIndex = 6;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow.BackColor = Color.White;
            btnShow.BackgroundImage = (Image)resources.GetObject("btnShow.BackgroundImage");
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatAppearance.MouseDownBackColor = Color.White;
            btnShow.FlatAppearance.MouseOverBackColor = Color.White;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.ForeColor = Color.Transparent;
            btnShow.Location = new Point(501, 260);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(23, 20);
            btnShow.TabIndex = 18;
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHide.BackColor = Color.White;
            btnHide.BackgroundImage = (Image)resources.GetObject("btnHide.BackgroundImage");
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatAppearance.MouseDownBackColor = Color.White;
            btnHide.FlatAppearance.MouseOverBackColor = Color.White;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Image = (Image)resources.GetObject("btnHide.Image");
            btnHide.Location = new Point(501, 260);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(23, 20);
            btnHide.TabIndex = 19;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBoQua.FlatStyle = FlatStyle.Flat;
            btnBoQua.Image = (Image)resources.GetObject("btnBoQua.Image");
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(439, 312);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(100, 30);
            btnBoQua.TabIndex = 17;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.TextAlign = ContentAlignment.MiddleRight;
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            btnDongY.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDongY.FlatStyle = FlatStyle.Flat;
            btnDongY.Image = (Image)resources.GetObject("btnDongY.Image");
            btnDongY.ImageAlign = ContentAlignment.MiddleLeft;
            btnDongY.Location = new Point(326, 312);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(95, 30);
            btnDongY.TabIndex = 16;
            btnDongY.Text = "Đồng ý";
            btnDongY.TextAlign = ContentAlignment.MiddleRight;
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 207);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 15;
            label8.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 157);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 14;
            label6.Text = "Địa chỉ:";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Location = new Point(144, 203);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(181, 28);
            cbbGioiTinh.TabIndex = 13;
            // 
            // txtAdress
            // 
            txtAdress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdress.Location = new Point(144, 154);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(395, 27);
            txtAdress.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 260);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(144, 257);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(395, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(144, 101);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(395, 27);
            txtPhone.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 104);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 2;
            label5.Text = "Số điện thoại:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(144, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(395, 27);
            txtName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 52);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Họ tên:";
            // 
            // FrmEmployeeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(622, 445);
            Controls.Add(lblTieuDe);
            Controls.Add(panel3);
            Name = "FrmEmployeeDetail";
            Text = "Thêm nhân viên";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Panel panel3;
        private Label label8;
        private Label label6;
        private ComboBox cbbGioiTinh;
        private TextBox txtAdress;
        private Label label7;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtName;
        private Label label4;
        private Button btnBoQua;
        private Button btnDongY;
        private Button btnShow;
        private Button btnHide;
    }
}