using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FrmQuanLyTruyen : Form
    {
        public FrmQuanLyTruyen()
        {
            InitializeComponent();
            LoadTable();
            LoadCategories();
        }

        void LoadTable()
        {
            var ls = ManagaDAO.Instance.getListManaga();
            managaDTOBindingSource1.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        void LoadCategories()
        {
            var ls = ManagaDAO.Instance.getListManaga();
            List<CategoryDTO> categoryList = new List<CategoryDTO>();
            categoryList.Add(new CategoryDTO { Id = -1, Title = "Tất cả", AmountManaga = ls.Count });

            // Lấy danh sách thể loại từ database và thêm vào danh sách đã tạo
            categoryList.AddRange(CategoryDAO.Instance.getListCategory());

            // Thiết lập DataSource cho ComboBox
            cbbTheLoai.DataSource = categoryList;
            cbbTheLoai.DisplayMember = "Display";
            cbbTheLoai.ValueMember = "Id";
        }

        void SearchManaga()
        {
            var ls = ManagaDAO.Instance.searchManaga(txtTimKiem.Text.ToLower());
            managaDTOBindingSource1.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn chặn sự kiện xuyên qua
                e.Handled = true;

                // Gọi hàm xử lý tìm kiếm
                SearchManaga();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchManaga();
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripCount.Text = "0";
            //Lấy thông tin của categorry đang chọn
            var ca = cbbTheLoai.SelectedItem as CategoryDTO;
            //Lấy danh sách managa của category đang chọn
            if (ca != null)
            {
                if (ca.Id == -1)
                {
                    LoadTable();
                }
                else
                {
                    var ls = ManagaDAO.Instance.filterManaga(ca);
                    managaDTOBindingSource1.DataSource = ls;
                    toolStripCount.Text = ls.Count.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new FrmTruyenDetail();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
                LoadTable();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var managa = managaDTOBindingSource1.Current as ManagaDTO;
            if (managa != null)
            {
                var f = new FrmTruyenDetail(managa);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadCategories();
                    LoadTable();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xác định managa đang chọn
            var managa = managaDTOBindingSource1.Current as ManagaDTO;
            if (managa != null)
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
                    ManagaDAO.Instance.DeleteManaga(managa.Id);
                    LoadCategories();
                    LoadTable();
                }

            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
