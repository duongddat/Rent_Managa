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
    public partial class FrmQuanLyKhachHang : Form
    {
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
            LoadTable();
        }

        void LoadTable()
        {
            var ls = CustomerDAO.Instance.getListCustomer();
            customerDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        void SearchCustomer()
        {
            var ls = CustomerDAO.Instance.searchCustomer(txtTimKiem.Text.ToLower());
            customerDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new FrmKhachHangDetail();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadTable();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var customer = customerDTOBindingSource.Current as CustomerDTO;
            if (customer != null)
            {
                var f = new FrmKhachHangDetail(customer);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadTable();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xác định managa đang chọn
            var customer = customerDTOBindingSource.Current as CustomerDTO;
            if (customer != null)
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
                    CustomerDAO.Instance.DeleteCustomer(customer.Id);
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
                SearchCustomer();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }
    }
}
