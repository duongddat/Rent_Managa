using QuanLyBanTruyen.DAO;
using QuanLyBanTruyen.DTO;
using QuanLyBanTruyen.Model;
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
    public partial class FrmCapNhatTaiKhoan : Form
    {
        EmployeeDTO employee;
        public FrmCapNhatTaiKhoan(EmployeeDTO employee)
        {
            InitializeComponent();
            this.employee = employee;
            loadGioiTinh();

            if (employee != null)
            {
                txtName.Text = employee.Name;
                txtPhone.Text = employee.Phone;
                txtAdress.Text = employee.Adress;
                cbbGioiTinh.SelectedValue = employee.GioiTinh;
            }
        }

        public class GioiTinh
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        void loadGioiTinh()
        {
            List<GioiTinh> items = new List<GioiTinh>
            {
                new GioiTinh { Id = 0, Name = "Nữ" },
                new GioiTinh { Id = 1, Name = "Nam" },
                new GioiTinh { Id = 2, Name = "Khác" }
            };

            cbbGioiTinh.DataSource = items;
            cbbGioiTinh.DisplayMember = "Name";
            cbbGioiTinh.ValueMember = "Id";
        }

        private bool ValidateAndUpdateEmployee(string name, string phone, string address, int gioiTinh)
        {
            int checkPhone;
            if (!int.TryParse(phone, out checkPhone))
            {
                MessageBox.Show("'Số điện thoại' không phải kiểu số!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (!employee.Phone.Equals(phone) && EmployeeDAO.Instance.getEmployeeByPhone(phone) != null)
            {
                MessageBox.Show("Không được trùng 'Số điện thoại'", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            // Cập nhật thông tin
            EmployeeDAO.Instance.EditEmployee(employee.Id, name, phone, address, gioiTinh, employee.Password, employee.isAdmin);

            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int gioiTinh = int.Parse(cbbGioiTinh.SelectedValue.ToString());
            string Name = txtName.Text;
            string Phone = txtPhone.Text;
            string Address = txtAdress.Text;

            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(Address))
            {
                bool isValid = ValidateAndUpdateEmployee(Name, Phone, Address, gioiTinh);

                if (isValid)
                {
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(EmployeeDAO.Instance.getEmployeeByPhone(Phone)));
                    }
                    MessageBox.Show("Cập nhật thông tin thành công!!!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
    }

    public class AccountEvent : EventArgs
    {
        public Employee employeeLogin { get; set; }
        public AccountEvent(Employee employeeLogin)
        {
            this.employeeLogin = employeeLogin;
        }
    }
}
