namespace QuanLyBanTruyen
{
    partial class FrmCapNhatTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapNhatTaiKhoan));
            panel1 = new Panel();
            txtPhone = new TextBox();
            label5 = new Label();
            btnCapNhat = new Button();
            label8 = new Label();
            label6 = new Label();
            cbbGioiTinh = new ComboBox();
            txtAdress = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCapNhat);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbbGioiTinh);
            panel1.Controls.Add(txtAdress);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(34, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 318);
            panel1.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(150, 106);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(406, 27);
            txtPhone.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 109);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 25;
            label5.Text = "Số điện thoại:";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhat.Location = new Point(453, 266);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(103, 34);
            btnCapNhat.TabIndex = 24;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.MiddleRight;
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 223);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 23;
            label8.Text = "Giới tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 165);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 22;
            label6.Text = "Địa chỉ:";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Location = new Point(150, 219);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(140, 28);
            cbbGioiTinh.TabIndex = 21;
            // 
            // txtAdress
            // 
            txtAdress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdress.Location = new Point(150, 162);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(406, 27);
            txtAdress.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(150, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(406, 27);
            txtName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 52);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 16;
            label4.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 28);
            label1.Name = "label1";
            label1.Size = new Size(406, 46);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // FrmCapNhatTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 395);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmCapNhatTaiKhoan";
            Text = "FrmCapNhatTaiKhoan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label8;
        private Label label6;
        private ComboBox cbbGioiTinh;
        private TextBox txtAdress;
        private TextBox txtName;
        private Label label4;
        private Button btnCapNhat;
        private TextBox txtPhone;
        private Label label5;
    }
}