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
    public partial class FrmTruyenDetail : Form
    {
        ManagaDTO managa;
        public FrmTruyenDetail(ManagaDTO managa = null)
        {
            InitializeComponent();
            this.managa = managa;
            LoadCategory();

            if (managa != null)
            {
                //Cập nhật
                this.Text = "Cập nhật truyện";
                lblTieuDe.Text = "CẬP NHẬT TRUYỆN";

                txtTenTruyen.Text = managa.Title;
                txtTacGia.Text = managa.Author;
                txtSoLuong.Text = managa.Amount.ToString();
                txtGia.Text = managa.Price.ToString();
                picAnhBia.ImageLocation = managa.Image;
                cbbTheLoai.SelectedValue = managa.IdCategory;
            }
        }

        void LoadCategory()
        {
            var ls = CategoryDAO.Instance.getListCategory();

            // Thiết lập DataSource cho ComboBox
            cbbTheLoai.DataSource = ls;
            cbbTheLoai.DisplayMember = "Title";
            cbbTheLoai.ValueMember = "Id";
        }

        private void picAnhBia_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                picAnhBia.ImageLocation = fileName;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var loai = cbbTheLoai.SelectedItem as CategoryDTO;
            string TenTruyen = txtTenTruyen.Text;
            string TacGia = txtTacGia.Text;

            if (!string.IsNullOrEmpty(TenTruyen) && !string.IsNullOrEmpty(TacGia))
            {
                string Anh = picAnhBia.ImageLocation;

                if (int.TryParse(txtSoLuong.Text, out int SoLuong) && long.TryParse(txtGia.Text, out long Gia))
                {
                    if (managa == null)
                    {
                        if (ManagaDAO.Instance.getManagaByName(TenTruyen) != null)
                        {
                            MessageBox.Show("'Tên truyện' đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        var newManaga = new Managa
                        {
                            Title = TenTruyen,
                            Author = TacGia,
                            Amount = SoLuong,
                            Price = Gia,
                            Image = Anh,
                            IdCategory = loai!.Id
                        };

                        ManagaDAO.Instance.AddManaga(newManaga);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        if (!managa.Title.Equals(TenTruyen) && ManagaDAO.Instance.getManagaByName(TenTruyen) != null)
                        {
                            MessageBox.Show("'Tên truyện' đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                        //Cập nhật thông tin managa
                        ManagaDAO.Instance.EditManaga(managa.Id, TenTruyen, TacGia, SoLuong, Gia, Anh, loai!.Id);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu số cho trường 'Số lượng' và 'Giá'!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống trường 'Tên truyện' và 'Tác giá'", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
