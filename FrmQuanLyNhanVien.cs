using QuanLyBanTruyen.DAO;
using QuanLyBanTruyen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanTruyen
{
    public partial class FrmQuanLyNV : Form
    {
        public FrmQuanLyNV()
        {
            InitializeComponent();
            LoadTable();
        }

        void LoadTable()
        {
            var ls = EmployeeDAO.Instance.getListEmployee();
            employeeDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        void SearchEmployee()
        {
            var ls = EmployeeDAO.Instance.searchEmployee(txtTimKiem.Text);
            employeeDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new FrmEmployeeDetail();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadTable();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var employee = employeeDTOBindingSource.Current as EmployeeDTO;
            if (employee != null)
            {
                var f = new FrmEmployeeDetail(employee);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadTable();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xác định managa đang chọn
            var employee = employeeDTOBindingSource.Current as EmployeeDTO;
            if (employee != null)
            {
                //Xác nhận xóa
                var rs = MessageBox.Show(
                    "Bạn có thực sự muốn xóa?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (rs == DialogResult.OK)
                {
                    //Xóa nếu oke
                    EmployeeDAO.Instance.DeleteEmployee(employee.Id);
                    LoadTable();
                }
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn chặn sự kiện xuyên qua
                e.Handled = true;

                // Gọi hàm xử lý tìm kiếm
                SearchEmployee();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }
    }
}
