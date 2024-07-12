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
    public partial class FrmEmployeeDetail : Form
    {
        EmployeeDTO employee;
        public FrmEmployeeDetail(EmployeeDTO employee = null)
        {
            InitializeComponent();
            this.employee = employee;
            loadGioiTinh();
            if (employee != null)
            {
                this.Text = "Cập nhật nhân viên";
                lblTieuDe.Text = "SỬA THÔNG TIN NHÂN VIÊN";

                txtName.Text = employee.Name;
                txtPhone.Text = employee.Phone;
                txtAdress.Text = employee.Adress;
                cbbGioiTinh.SelectedValue = employee.GioiTinh;
                txtPassword.Text = employee.Password;
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

        private void btnDongY_Click(object sender, EventArgs e)
        {
            int gioiTinh = int.Parse(cbbGioiTinh.SelectedValue.ToString());
            string Name = txtName.Text;
            string Phone = txtPhone.Text;
            string Adress = txtAdress.Text;
            string Password = txtPassword.Text;

            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(Adress) && !string.IsNullOrEmpty(Password))
            {
                if (employee == null)
                {
                    int checkPhone;
                    if (!int.TryParse(Phone, out checkPhone))
                    {
                        MessageBox.Show("'Số điện thoại' không phải kiểu số!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    if (EmployeeDAO.Instance.getEmployeeByPhone(Phone) != null)
                    {
                        MessageBox.Show("Không được trùng 'Số điện thoại'", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    var newEmployee = new Employee
                    {
                        Name = Name,
                        Phone = Phone,
                        Adress = Adress,
                        GioiTinh = gioiTinh,
                        password = Password,
                        isAdmin = false
                    };

                    EmployeeDAO.Instance.AddEmloyee(newEmployee);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    if (!employee.Phone.Equals(Phone) && EmployeeDAO.Instance.getEmployeeByPhone(Phone) != null)
                    {
                        MessageBox.Show("Không được trùng 'Số điện thoại'", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    //Cập nhật thông tin managa
                    EmployeeDAO.Instance.EditEmployee(employee.Id, Name, Phone, Adress, gioiTinh, Password, false);
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void TogglePasswordVisibility()
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnShow.Visible = txtPassword.UseSystemPasswordChar;
            btnHide.Visible = !txtPassword.UseSystemPasswordChar;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }
    }
}
