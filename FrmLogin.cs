using QuanLyBanTruyen.DAO;
using QuanLyBanTruyen.DTO;

namespace QuanLyBanTruyen
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /*        bool Login(string phoneNumber, string passWord)
                {
                    return EmployeeDAO.Instance.Login(phoneNumber, passWord);
                }*/

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;
            string passWord = txtPassword.Text;
            if (phoneNumber == "" || passWord == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin để đăng nhập!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                EmployeeDTO login = EmployeeDAO.Instance.GetAccout(phoneNumber, passWord);

                if (login != null)
                {

                    FrmManager frm = new FrmManager(login);
                    this.Hide();
                    txtPhone.Text = "";
                    txtPassword.Text = "";
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai số điện thoại hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
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