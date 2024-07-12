namespace QuanLyBanTruyen
{
    partial class FrmChiTietHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietHD));
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdOrder = new DataGridViewTextBoxColumn();
            IdManaga = new DataGridViewTextBoxColumn();
            NameManaga = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            orderDetailDTOBindingSource = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            btnXoa = new ToolStripButton();
            label1 = new Label();
            toolStripCount = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(35, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 485);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(740, 434);
            button1.Name = "button1";
            button1.Size = new Size(107, 37);
            button1.TabIndex = 1;
            button1.Text = "Trở về";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(statusStrip1);
            panel2.Controls.Add(toolStrip1);
            panel2.Location = new Point(17, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 385);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, IdOrder, IdManaga, NameManaga, Amount, TotalPrice });
            dataGridView1.DataSource = orderDetailDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(830, 332);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // IdOrder
            // 
            IdOrder.DataPropertyName = "IdOrder";
            IdOrder.HeaderText = "Mã HĐ";
            IdOrder.MinimumWidth = 6;
            IdOrder.Name = "IdOrder";
            IdOrder.Width = 125;
            // 
            // IdManaga
            // 
            IdManaga.DataPropertyName = "IdManaga";
            IdManaga.HeaderText = "Mã Truyện";
            IdManaga.MinimumWidth = 6;
            IdManaga.Name = "IdManaga";
            IdManaga.Width = 125;
            // 
            // NameManaga
            // 
            NameManaga.DataPropertyName = "NameManaga";
            NameManaga.HeaderText = "Tên Truyện";
            NameManaga.MinimumWidth = 6;
            NameManaga.Name = "NameManaga";
            NameManaga.Width = 125;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Số Lượng";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Tổng tiền";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            // 
            // orderDetailDTOBindingSource
            // 
            orderDetailDTOBindingSource.DataSource = typeof(DTO.OrderDetailDTO);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripCount });
            statusStrip1.Location = new Point(0, 359);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(830, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(147, 20);
            toolStripStatusLabel1.Text = "Tổng số chi tiết HĐ:";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, btnXoa });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(830, 27);
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
            toolStripButton1.Size = new Size(167, 24);
            toolStripButton1.Text = "Danh sách chi tiết HĐ:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 46);
            label1.TabIndex = 1;
            label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // toolStripCount
            // 
            toolStripCount.Name = "toolStripCount";
            toolStripCount.Size = new Size(0, 20);
            // 
            // FrmChiTietHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(924, 532);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmChiTietHD";
            Text = "FrmChiTietHD";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private Button button1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton btnXoa;
        private BindingSource orderDetailDTOBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdOrder;
        private DataGridViewTextBoxColumn IdManaga;
        private DataGridViewTextBoxColumn NameManaga;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TotalPrice;
        private ToolStripStatusLabel toolStripCount;
    }
}