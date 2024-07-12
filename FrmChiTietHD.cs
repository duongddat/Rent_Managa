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
    public partial class FrmChiTietHD : Form
    {
        int OrderID;
        public FrmChiTietHD(int OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
            LoadTable();
        }

        void LoadTable()
        {
            var ls = OrderDetailDAO.Instance.getList(OrderID);
            orderDetailDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var orderDetail = orderDetailDTOBindingSource.Current as OrderDetailDTO;
            if (orderDetail != null)
            {
                OrderDetailDAO.Instance.DeleteOrderDetail(orderDetail.Id);
                var ls = OrderDetailDAO.Instance.getList(OrderID);
                if (ls == null)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    LoadTable();
                }
            }
        }
    }
}
