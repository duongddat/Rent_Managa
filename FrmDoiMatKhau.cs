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

namespace QuanLyBanTruyen
{
    public partial class FrmDoiMatKhau : Form
    {
        EmployeeDTO employee;

        public FrmDoiMatKhau(EmployeeDTO employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private bool ValidateInputs(string matKhau, string matKhauMoi, string nhapLai)
        {
            if (string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(nhapLai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (!matKhauMoi.Equals(nhapLai))
            {
                MessageBox.Show("Vui lòng nhập lại đúng với mật khẩu mới", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (!matKhau.Equals(employee.Password))
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matKhau = txtMatKhau.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLai = txtNhapLai.Text;

            if (ValidateInputs(matKhau, matKhauMoi, nhapLai))
            {
                if (EmployeeDAO.Instance.ChangePassword(employee.Id, employee.Phone, matKhauMoi))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                    txtMatKhau.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtNhapLai.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi không thể đổi mật khẩu! Vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
