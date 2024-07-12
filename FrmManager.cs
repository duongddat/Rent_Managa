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
    public partial class FrmManager : Form
    {
        private EmployeeDTO loginEmployee { get; set; }
        public FrmManager(EmployeeDTO login)
        {
            InitializeComponent();
            SetRandomBackgroundImage();

            this.loginEmployee = login;

            if (loginEmployee != null)
            {
                labelUserName.Text = loginEmployee.Name;
                tàiKhoảnToolStripMenuItem.Text += " (" + loginEmployee.Name + ")";
                CheckAdminPermissions();
            }
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private List<string> fixedBackgroundImagePaths = new List<string>
        {
            "E:\\Nam4\\DotNet\\ImgProject\\bg1.png",
            "E:\\Nam4\\DotNet\\ImgProject\\bg2.jpg",
            "E:\\Nam4\\DotNet\\ImgProject\\bg5.png",
            "E:\\Nam4\\DotNet\\ImgProject\\bg5.jpg",
            "E:\\Nam4\\DotNet\\ImgProject\\bg9.jpg",
        };

        private Random random = new Random();

        private void SetRandomBackgroundImage()
        {
            // Kiểm tra xem có hình nền nào không
            if (fixedBackgroundImagePaths.Count > 0)
            {
                // Chọn một đường dẫn ngẫu nhiên từ danh sách
                string randomImagePath = fixedBackgroundImagePaths[random.Next(fixedBackgroundImagePaths.Count)];

                // Đặt hình nền cho Panel
                panel_Body.BackgroundImage = System.Drawing.Image.FromFile(randomImagePath);
                // Thay đổi SizeMode nếu cần
                panel_Body.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void CheckAdminPermissions()
        {
            // Nếu quyền Admin đã đăng nhập, hiển thị ToolStripMenuItems cần thiết
            if (loginEmployee.isAdmin)
            {
                quảnLýDanhMụcToolStripMenuItem.Visible = true;
                thôngKêDoanhThuToolStripMenuItem.Visible = true;
            }
            else
            {
                // Nếu không phải Admin, ẩn ToolStripMenuItems
                quảnLýDanhMụcToolStripMenuItem.Visible = false;
                thôngKêDoanhThuToolStripMenuItem.Visible = false;
            }
        }

        private void quảnLýTruyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FrmQuanLyTruyen frmQuanLyTruyen = new FrmQuanLyTruyen();
            frmQuanLyTruyen.ShowDialog();*/
            OpenChildForm(new FrmQuanLyTruyen());
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyKhachHang());
        }

        private void quảnLýLoạiTruyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyTheLoai());
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyNV());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDoiMatKhau(loginEmployee));
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            SetRandomBackgroundImage();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginEmployee = null;
            this.Close();
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCreateOrder(loginEmployee));
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachHD(loginEmployee));
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCapNhatTaiKhoan f = new FrmCapNhatTaiKhoan(loginEmployee);
            f.UpdateAccount += F_UpdateAccount;
            OpenChildForm(f);
        }

        private void F_UpdateAccount(object? sender, AccountEvent e)
        {
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản (" + e.employeeLogin.Name + ")";
            this.loginEmployee = new EmployeeDTO
            {
                Id = e.employeeLogin.Id,
                Name = e.employeeLogin.Name,
                Phone = e.employeeLogin.Phone,
                Adress = e.employeeLogin.Adress,
                GioiTinh = e.employeeLogin.GioiTinh,
                Password = e.employeeLogin.password,
                isAdmin = e.employeeLogin.isAdmin,
            };
            labelUserName.Text = loginEmployee.Name;
        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe());
        }
    }
}
