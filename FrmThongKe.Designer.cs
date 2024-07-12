namespace QuanLyBanTruyen
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            panel1 = new Panel();
            label2 = new Label();
            cbbThongKe = new ComboBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            displayThangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayDoanhThuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thongKeDTOBindingSource = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripTongTien = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            label1 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thongKeDTOBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbbThongKe);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(29, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 544);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(599, 47);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Năm";
            // 
            // cbbThongKe
            // 
            cbbThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbThongKe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbThongKe.FormattingEnabled = true;
            cbbThongKe.Location = new Point(668, 43);
            cbbThongKe.Name = "cbbThongKe";
            cbbThongKe.Size = new Size(215, 28);
            cbbThongKe.TabIndex = 1;
            cbbThongKe.SelectedIndexChanged += cbbThongKe_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(statusStrip1);
            panel2.Controls.Add(toolStrip1);
            panel2.Location = new Point(35, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 435);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { displayThangDataGridViewTextBoxColumn, displayDoanhThuDataGridViewTextBoxColumn });
            dataGridView1.DataSource = thongKeDTOBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(846, 380);
            dataGridView1.TabIndex = 0;
            // 
            // displayThangDataGridViewTextBoxColumn
            // 
            displayThangDataGridViewTextBoxColumn.DataPropertyName = "DisplayThang";
            displayThangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            displayThangDataGridViewTextBoxColumn.MinimumWidth = 6;
            displayThangDataGridViewTextBoxColumn.Name = "displayThangDataGridViewTextBoxColumn";
            displayThangDataGridViewTextBoxColumn.ReadOnly = true;
            displayThangDataGridViewTextBoxColumn.Width = 125;
            // 
            // displayDoanhThuDataGridViewTextBoxColumn
            // 
            displayDoanhThuDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            displayDoanhThuDataGridViewTextBoxColumn.DataPropertyName = "DisplayDoanhThu";
            displayDoanhThuDataGridViewTextBoxColumn.HeaderText = "Doanh Thu";
            displayDoanhThuDataGridViewTextBoxColumn.MinimumWidth = 6;
            displayDoanhThuDataGridViewTextBoxColumn.Name = "displayDoanhThuDataGridViewTextBoxColumn";
            displayDoanhThuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thongKeDTOBindingSource
            // 
            thongKeDTOBindingSource.DataSource = typeof(DTO.ThongKeDTO);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripTongTien });
            statusStrip1.Location = new Point(0, 407);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(846, 26);
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(846, 27);
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
            toolStripButton1.Size = new Size(161, 24);
            toolStripButton1.Text = "Danh sách doanh thu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 46);
            label1.TabIndex = 1;
            label1.Text = "THỐNG KÊ & BÁO CÁO";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 607);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)thongKeDTOBindingSource).EndInit();
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
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripStatusLabel toolStripTongTien;
        private ComboBox cbbThongKe;
        private Label label2;
        private BindingSource thongKeDTOBindingSource;
        private DataGridViewTextBoxColumn displayThangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayDoanhThuDataGridViewTextBoxColumn;
    }
}