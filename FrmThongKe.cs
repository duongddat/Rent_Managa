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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
            LoadNam();
        }

        void LoadNam()
        {
            cbbThongKe.DataSource = OrderDAO.Instance.ListYearRevenue();
        }

        void LoadTable(int nam)
        {
            var ls = OrderDAO.Instance.ThongKeDoanhThuTheoNam(nam);
            thongKeDTOBindingSource.DataSource = ls;
            toolStripTongTien.Text = ThongKeDTO.TinhTongDoanhThu(ls).ToString() + " đồng";
        }

        private void cbbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = int.Parse(cbbThongKe.SelectedValue.ToString());
            LoadTable(nam);
        }
    }
}
