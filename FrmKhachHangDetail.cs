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
    public partial class FrmKhachHangDetail : Form
    {
        CustomerDTO customer;
        public FrmKhachHangDetail(CustomerDTO customer = null)
        {
            InitializeComponent();
            this.customer = customer;
            loadGioiTinh();
            if (customer != null)
            {
                this.Text = "Cập nhật khách hàng";
                lblTieuDe.Text = "Chỉnh sửa thông tin khác hàng";

                txtName.Text = customer.Name;
                txtPhone.Text = customer.Phone;
                txtAdress.Text = customer.Adress;
                cbbGioiTinh.SelectedValue = customer.GioiTinh;
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

            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(Adress))
            {
                int checkPhone;
                if (!int.TryParse(Phone, out checkPhone))
                {
                    MessageBox.Show("'Số điện thoại' không phải kiểu số!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (customer == null)
                {
                    if (CustomerDAO.Instance.getCustomerByPhone(Phone) != null)
                    {
                        MessageBox.Show("Không được trùng 'Số điện thoại'", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    var newCustomer = new Customer
                    {
                        Name = Name,
                        Phone = Phone,
                        Adress = Adress,
                        GioiTinh = gioiTinh
                    };

                    CustomerDAO.Instance.AddCustomer(newCustomer);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    if (!customer.Phone.Equals(Phone) && CustomerDAO.Instance.getCustomerByPhone(Phone) != null)
                    {
                        MessageBox.Show("Không được trùng 'Số điện thoại'", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    //Cập nhật thông tin managa
                    CustomerDAO.Instance.EditCustomer(customer.Id, Name, Phone, Adress, gioiTinh);
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
