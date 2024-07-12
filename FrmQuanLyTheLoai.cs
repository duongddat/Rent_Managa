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
    public partial class FrmQuanLyTheLoai : Form
    {
        public FrmQuanLyTheLoai()
        {
            InitializeComponent();
            LoadTable();
        }

        public void LoadTable()
        {
            var ls = CategoryDAO.Instance.getListCategory();
            categoryDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        public void searchCategory()
        {
            var ls = CategoryDAO.Instance.searchCategory(txtTimKiem.Text);
            categoryDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn chặn sự kiện xuyên qua
                e.Handled = true;

                // Gọi hàm xử lý tìm kiếm
                searchCategory();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            searchCategory();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            if (!string.IsNullOrEmpty(Title))
            {
                if (CategoryDAO.Instance.getCategoryByTitle(Title) != null)
                {
                    MessageBox.Show("Không được trùng tên thể loại truyện", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                Category newCategory = new Category
                {
                    Title = Title
                };

                CategoryDAO.Instance.AddCategory(newCategory);
                LoadTable();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên thể loại truyện", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            if (!string.IsNullOrEmpty(Title))
            {
                if (CategoryDAO.Instance.getCategoryByTitle(Title) != null)
                {
                    MessageBox.Show("Không được trùng tên thể loại truyện", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                var category = categoryDTOBindingSource.Current as CategoryDTO;
                if (category != null)
                {
                    CategoryDAO.Instance.EditCategory(category.Id, Title);
                    txtTitle.Text = "";
                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên thể loại truyện", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var category = categoryDTOBindingSource.Current as CategoryDTO;
            if (category != null)
            {
                txtTitle.Text = category.Title;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var category = categoryDTOBindingSource.Current as CategoryDTO;
            if (category != null)
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
                    CategoryDAO.Instance.DeleteCategory(category.Id);
                    txtTitle.Text = "";
                    LoadTable();
                }
            }
        }
    }
}
