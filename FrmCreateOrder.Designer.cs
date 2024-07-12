namespace QuanLyBanTruyen
{
    partial class FrmCreateOrder
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateOrder));
            panel1 = new Panel();
            panel5 = new Panel();
            dataGridView2 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            managaDTOBindingSource = new BindingSource(components);
            statusStrip2 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripCount = new ToolStripStatusLabel();
            toolStrip2 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            btnAddCart = new ToolStripButton();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            NameManaga = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price1 = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            cartDTOBindingSource = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripTongTien = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            btnDon = new ToolStripButton();
            btnXoa = new ToolStripButton();
            btnSua = new ToolStripButton();
            btnTaoHD = new ToolStripButton();
            label3 = new Label();
            panel3 = new Panel();
            cbbTheLoai = new ComboBox();
            label9 = new Label();
            txtSearch = new TextBox();
            label8 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            cbbGioiTinh = new ComboBox();
            btnControl = new Button();
            label6 = new Label();
            txtAdress = new TextBox();
            label7 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)managaDTOBindingSource).BeginInit();
            statusStrip2.SuspendLayout();
            toolStrip2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartDTOBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(26, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 600);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView2);
            panel5.Controls.Add(statusStrip2);
            panel5.Controls.Add(toolStrip2);
            panel5.Location = new Point(494, 274);
            panel5.Name = "panel5";
            panel5.Size = new Size(427, 319);
            panel5.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Amount, Price, CategoryName });
            dataGridView2.DataSource = managaDTOBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(425, 264);
            dataGridView2.TabIndex = 0;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Tên Truyện";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Tác giả";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Số lượng";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Thể loại";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            // 
            // managaDTOBindingSource
            // 
            managaDTOBindingSource.DataSource = typeof(DTO.ManagaDTO);
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, toolStripCount });
            statusStrip2.Location = new Point(0, 291);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(425, 26);
            statusStrip2.TabIndex = 2;
            statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(119, 20);
            toolStripStatusLabel2.Text = "Tổng số truyện:";
            // 
            // toolStripCount
            // 
            toolStripCount.Name = "toolStripCount";
            toolStripCount.Size = new Size(0, 20);
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton2, btnAddCart });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(425, 27);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(139, 24);
            toolStripButton2.Text = "Danh sách truyện:";
            // 
            // btnAddCart
            // 
            btnAddCart.Alignment = ToolStripItemAlignment.Right;
            btnAddCart.Image = (Image)resources.GetObject("btnAddCart.Image");
            btnAddCart.ImageTransparentColor = Color.Magenta;
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(124, 24);
            btnAddCart.Text = "Thêm vào giỏ";
            btnAddCart.Click += btnAddCart_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(statusStrip1);
            panel4.Controls.Add(toolStrip1);
            panel4.Location = new Point(26, 274);
            panel4.Name = "panel4";
            panel4.Size = new Size(462, 319);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameManaga, Quantity, Price1, Subtotal });
            dataGridView1.DataSource = cartDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(460, 264);
            dataGridView1.TabIndex = 0;
            // 
            // NameManaga
            // 
            NameManaga.DataPropertyName = "NameManaga";
            NameManaga.HeaderText = "Tên truyện";
            NameManaga.MinimumWidth = 6;
            NameManaga.Name = "NameManaga";
            NameManaga.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Price1
            // 
            Price1.DataPropertyName = "Price";
            Price1.HeaderText = "Giá";
            Price1.MinimumWidth = 6;
            Price1.Name = "Price1";
            Price1.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subtotal.DataPropertyName = "Subtotal";
            Subtotal.HeaderText = "Thành tiền";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // cartDTOBindingSource
            // 
            cartDTOBindingSource.DataSource = typeof(DTO.CartDTO);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripTongTien });
            statusStrip1.Location = new Point(0, 291);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(460, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(80, 20);
            toolStripStatusLabel1.Text = "Tổng tiền:";
            // 
            // toolStripTongTien
            // 
            toolStripTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripTongTien.ForeColor = Color.Red;
            toolStripTongTien.Name = "toolStripTongTien";
            toolStripTongTien.Size = new Size(0, 20);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, btnDon, btnXoa, btnSua, btnTaoHD });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(460, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(142, 24);
            toolStripButton1.Text = "Thông tin hóa đơn";
            // 
            // btnDon
            // 
            btnDon.Alignment = ToolStripItemAlignment.Right;
            btnDon.Image = (Image)resources.GetObject("btnDon.Image");
            btnDon.ImageTransparentColor = Color.Magenta;
            btnDon.Name = "btnDon";
            btnDon.Size = new Size(61, 24);
            btnDon.Text = "Dọn";
            btnDon.Click += btnDon_Click;
            // 
            // btnXoa
            // 
            btnXoa.Alignment = ToolStripItemAlignment.Right;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(59, 24);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Alignment = ToolStripItemAlignment.Right;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageTransparentColor = Color.Magenta;
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(58, 24);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Alignment = ToolStripItemAlignment.Right;
            btnTaoHD.Image = (Image)resources.GetObject("btnTaoHD.Image");
            btnTaoHD.ImageTransparentColor = Color.Magenta;
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(84, 24);
            btnTaoHD.Text = "Tạo HĐ";
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 173);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 1;
            label3.Text = "Công cụ tìm kiếm:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cbbTheLoai);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(26, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(895, 72);
            panel3.TabIndex = 2;
            // 
            // cbbTheLoai
            // 
            cbbTheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTheLoai.FormattingEnabled = true;
            cbbTheLoai.Location = new Point(605, 22);
            cbbTheLoai.Name = "cbbTheLoai";
            cbbTheLoai.Size = new Size(253, 28);
            cbbTheLoai.TabIndex = 11;
            cbbTheLoai.SelectedIndexChanged += cbbTheLoai_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(501, 26);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 10;
            label9.Text = "Thể loại:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(140, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(261, 27);
            txtSearch.TabIndex = 5;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 26);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 4;
            label8.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 15);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 0;
            label2.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbbGioiTinh);
            panel2.Controls.Add(btnControl);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtAdress);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(26, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 140);
            panel2.TabIndex = 0;
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Location = new Point(605, 59);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(253, 28);
            cbbGioiTinh.TabIndex = 9;
            // 
            // btnControl
            // 
            btnControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnControl.Location = new Point(719, 98);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(139, 27);
            btnControl.TabIndex = 8;
            btnControl.Text = "Thêm khách hàng";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(501, 63);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 6;
            label6.Text = "Giới tính:";
            // 
            // txtAdress
            // 
            txtAdress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAdress.Location = new Point(605, 16);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(253, 27);
            txtAdress.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(501, 19);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 4;
            label7.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(140, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 27);
            txtName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 63);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 2;
            label5.Text = "Họ và tên:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(140, 16);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Nhập số điện thoại";
            txtPhone.Size = new Size(261, 27);
            txtPhone.TabIndex = 1;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyDown += txtPhone_KeyDown;
            txtPhone.Leave += txtPhone_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 19);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 0;
            label4.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 46);
            label1.TabIndex = 1;
            label1.Text = "TẠO HÓA ĐƠN";
            // 
            // FrmCreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 646);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmCreateOrder";
            Text = "FrmCreateOrder";
            Resize += FrmCreateOrder_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)managaDTOBindingSource).EndInit();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartDTOBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private Button btnControl;
        private Label label6;
        private TextBox txtAdress;
        private Label label7;
        private Panel panel4;
        private ToolStrip toolStrip1;
        private DataGridView dataGridView1;
        private ComboBox cbbGioiTinh;
        private Panel panel5;
        private StatusStrip statusStrip2;
        private ToolStrip toolStrip2;
        private DataGridView dataGridView2;
        private StatusStrip statusStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripTongTien;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripCount;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnAddCart;
        private BindingSource managaDTOBindingSource;
        private ComboBox cbbTheLoai;
        private Label label9;
        private TextBox txtSearch;
        private Label label8;
        private ToolStripButton btnDon;
        private ToolStripButton btnTaoHD;
        private BindingSource cartDTOBindingSource;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn NameManaga;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price1;
        private DataGridViewTextBoxColumn Subtotal;
        private ToolStripButton btnXoa;
        private ToolStripButton btnSua;
    }
}