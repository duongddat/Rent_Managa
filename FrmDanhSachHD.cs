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
    public partial class FrmDanhSachHD : Form
    {
        EmployeeDTO employee;
        public FrmDanhSachHD(EmployeeDTO employee)
        {
            InitializeComponent();
            this.employee = employee;
            LoadTable();
        }

        void LoadTable()
        {
            var ls = OrderDAO.Instance.getList(employee.Id, employee.isAdmin);
            orderDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            var order = orderDTOBindingSource.Current as OrderDTO;
            if (order != null)
            {
                var f = new FrmChiTietHD(order.Id);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadTable();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var order = orderDTOBindingSource.Current as OrderDTO;
            if (order != null)
            {
                OrderDAO.Instance.DeleteOrderAndDetails(order.Id);
                LoadTable();
            }
        }
    }
}
