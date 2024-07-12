namespace QuanLyBanTruyen
{
    partial class FrmTruyenDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTruyenDetail));
            panel1 = new Panel();
            btnBoQua = new Button();
            btnDongY = new Button();
            picAnhBia = new PictureBox();
            label7 = new Label();
            cbbTheLoai = new ComboBox();
            label6 = new Label();
            txtGia = new TextBox();
            label5 = new Label();
            txtSoLuong = new TextBox();
            label4 = new Label();
            txtTacGia = new TextBox();
            label3 = new Label();
            txtTenTruyen = new TextBox();
            label2 = new Label();
            lblTieuDe = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnDongY);
            panel1.Controls.Add(picAnhBia);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbbTheLoai);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTacGia);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTenTruyen);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(39, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 427);
            panel1.TabIndex = 0;
            // 
            // btnBoQua
            // 
            btnBoQua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBoQua.FlatStyle = FlatStyle.Flat;
            btnBoQua.Image = (Image)resources.GetObject("btnBoQua.Image");
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(575, 365);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(99, 36);
            btnBoQua.TabIndex = 6;
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
            btnDongY.Location = new Point(461, 365);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(99, 36);
            btnDongY.TabIndex = 5;
            btnDongY.Text = "Đồng ý";
            btnDongY.TextAlign = ContentAlignment.MiddleRight;
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // picAnhBia
            // 
            picAnhBia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picAnhBia.BorderStyle = BorderStyle.FixedSingle;
            picAnhBia.Location = new Point(532, 171);
            picAnhBia.Name = "picAnhBia";
            picAnhBia.Size = new Size(142, 150);
            picAnhBia.SizeMode = PictureBoxSizeMode.Zoom;
            picAnhBia.TabIndex = 11;
            picAnhBia.TabStop = false;
            picAnhBia.Click += picAnhBia_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(439, 174);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 10;
            label7.Text = "Ảnh bìa:";
            // 
            // cbbTheLoai
            // 
            cbbTheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTheLoai.FormattingEnabled = true;
            cbbTheLoai.Location = new Point(134, 174);
            cbbTheLoai.Name = "cbbTheLoai";
            cbbTheLoai.Size = new Size(261, 28);
            cbbTheLoai.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 178);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 8;
            label6.Text = "Thể loại:";
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGia.Location = new Point(134, 294);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(261, 27);
            txtGia.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 297);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 6;
            label5.Text = "Giá:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSoLuong.Location = new Point(134, 235);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(261, 27);
            txtSoLuong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 238);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Số lượng:";
            // 
            // txtTacGia
            // 
            txtTacGia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTacGia.Location = new Point(134, 111);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(540, 27);
            txtTacGia.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 114);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Tác giả:";
            // 
            // txtTenTruyen
            // 
            txtTenTruyen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenTruyen.Location = new Point(134, 53);
            txtTenTruyen.Name = "txtTenTruyen";
            txtTenTruyen.Size = new Size(540, 27);
            txtTenTruyen.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 56);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên truyện:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.ForeColor = Color.FromArgb(0, 192, 192);
            lblTieuDe.Location = new Point(63, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(259, 46);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "THÊM TRUYỆN";
            // 
            // FrmTruyenDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(811, 483);
            Controls.Add(lblTieuDe);
            Controls.Add(panel1);
            Name = "FrmTruyenDetail";
            Text = "Thêm truyện";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTieuDe;
        private TextBox txtTenTruyen;
        private Label label2;
        private TextBox txtTacGia;
        private Label label3;
        private TextBox txtSoLuong;
        private Label label4;
        private TextBox txtGia;
        private Label label5;
        private Label label7;
        private ComboBox cbbTheLoai;
        private Label label6;
        private PictureBox picAnhBia;
        private Button btnBoQua;
        private Button btnDongY;
    }
}