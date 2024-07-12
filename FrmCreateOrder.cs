using Microsoft.VisualBasic;
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
    public partial class FrmCreateOrder : Form
    {
        EmployeeDTO employee;
        Customer customer = null;
        List<CartDTO> Items { get; set; }
        public FrmCreateOrder(EmployeeDTO employee)
        {
            InitializeComponent();
            AdjustPanelSizes();

            this.employee = employee;

            LoadGioiTinh();
            LoadTheLoai();
            LoadSanPham();
        }

        void LoadSanPham()
        {
            var ls = ManagaDAO.Instance.getListManaga();
            managaDTOBindingSource.DataSource = ls;
            toolStripCount.Text = ls.Count.ToString();
        }

        void LoadTheLoai()
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

        public class GioiTinh
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        void LoadGioiTinh()
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

        void AddItem(CartDTO item)
        {
            if (Items == null)
            {
                Items = new List<CartDTO>(); // Initialize the Items list if it's null
            }

            var existingItem = Items.FirstOrDefault(i => i.IdManaga == item.IdManaga);

            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }

        void EditItem(int IdManaga, int amount)
        {
            var existingItem = Items.FirstOrDefault(i => i.IdManaga == IdManaga);

            if (existingItem != null)
            {
                existingItem.Quantity = amount;
            }
        }


        void RemoveItem(int IdManaga)
        {
            var itemToRemove = Items.FirstOrDefault(i => i.IdManaga == IdManaga);

            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }

        long CalculateTotal()
        {
            return Items.Sum(item => item.Subtotal);
        }

        void LoadCart()
        {
            cartDTOBindingSource.DataSource = null;
            cartDTOBindingSource.DataSource = Items;
            cartDTOBindingSource.ResetBindings(false);
            toolStripTongTien.Text = CalculateTotal().ToString() + " đồng";
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                customer = CustomerDAO.Instance.getCustomerByPhone(txtPhone.Text);
                if (customer != null)
                {
                    txtName.Text = customer.Name;
                    txtAdress.Text = customer.Adress;
                    cbbGioiTinh.SelectedValue = customer.GioiTinh;
                    btnControl.Text = "Cập nhật";
                }
                else
                {
                    customer = null;
                    txtName.Text = "";
                    txtAdress.Text = "";
                    cbbGioiTinh.SelectedValue = 1;
                    btnControl.Text = "Thêm khách hàng";
                }
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
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
                    customer = newCustomer;
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    btnControl.Text = "Cập nhật";
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
                    customer = CustomerDAO.Instance.getCustomerByPhone(Phone);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var ls = ManagaDAO.Instance.searchManaga(txtSearch.Text.ToLower());
                managaDTOBindingSource.DataSource = ls;
                toolStripCount.Text = ls.Count.ToString();
            }
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
                    LoadSanPham();
                }
                else
                {
                    var ls = ManagaDAO.Instance.filterManaga(ca);
                    managaDTOBindingSource.DataSource = ls;
                    toolStripCount.Text = ls.Count.ToString();
                }
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            var managa = managaDTOBindingSource.Current as ManagaDTO;
            if (managa != null)
            {
                if (managa.Amount == 0)
                {
                    MessageBox.Show("Truyện đã hết hàng!!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                string input = Interaction.InputBox("Nhập số lượng:", "Số lượng mua", "1");
                if (!string.IsNullOrEmpty(input))
                {

                    // Kiểm tra xem số lượng có phải là số nguyên dương hay không
                    if (int.TryParse(input, out int quantity) && quantity > 0)
                    {
                        int ItemAmount = 0;
                        if (Items != null)
                        {
                            var existingItem = Items.FirstOrDefault(i => i.IdManaga == managa.Id);
                            ItemAmount = existingItem != null ? existingItem.Quantity : 0;
                        }

                        if (managa.Amount < quantity + ItemAmount)
                        {
                            MessageBox.Show("Số lượng truyện không đủ!!!", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        CartDTO cartItem = new CartDTO
                        {
                            IdManaga = managa.Id,
                            NameManaga = managa.Title,
                            Quantity = quantity,
                            Price = managa.Price,
                        };

                        AddItem(cartItem);
                        LoadCart();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số nguyên dương.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void FrmCreateOrder_Resize(object sender, EventArgs e)
        {
            AdjustPanelSizes();
        }

        void AdjustPanelSizes()
        {
            int newPanelWidth = (panel1.Width - 40) / 2;

            // Đặt lại kích thước của các Panel
            panel4.Width = newPanelWidth;
            panel5.Width = newPanelWidth;

            // Cập nhật vị trí của Panel5 dựa trên chiều rộng mới của Panel4 và khoảng cách
            panel5.Left = panel4.Right;
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            //Xác nhận xóa
            var rs = MessageBox.Show(
                "Bạn có thực sự muốn xóa hết sản phẩm trong giỏ hàng?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.OK)
            {
                //Xóa nếu oke
                Items.Clear();
                LoadCart();
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show(
                "Bạn có thực sự muốn tạo hóa đơn?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.OK)
            {
                if (customer == null)
                {
                    MessageBox.Show("Chưa nhập thông tin khách hàng!!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (Items == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để tạo hóa đơn!!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                DateTime currentDateTimeString = DateTime.Now;
                //Tạo hóa đơn và chi tiết hóa đơn
                //Tạo hóa đơn
                Order newOrder = new Order
                {
                    OrderDate = currentDateTimeString,
                    CustomerId = customer.Id,
                    EmployeeId = employee.Id
                };

                int OrderID = OrderDAO.Instance.AddOrder(newOrder);
                //Tạo chi tiết hóa đơn
                OrderDetailDAO.Instance.AddOrderDetails(Items, OrderID);

                //Reset dữ liệu
                Items.Clear();
                LoadCart();
                LoadSanPham();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            customer = CustomerDAO.Instance.getCustomerByPhone(txtPhone.Text);
            if (customer != null)
            {
                txtName.Text = customer.Name;
                txtAdress.Text = customer.Adress;
                cbbGioiTinh.SelectedValue = customer.GioiTinh;
                btnControl.Text = "Cập nhật";
            }
            else
            {
                customer = null;
                txtName.Text = "";
                txtAdress.Text = "";
                cbbGioiTinh.SelectedValue = 1;
                btnControl.Text = "Thêm khách hàng";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var item = cartDTOBindingSource.Current as CartDTO;
            if (item != null)
            {
                //Xác nhận xóa
                var rs = MessageBox.Show(
                    "Bạn có thực sự muốn xóa sản phẩm này ra khỏi giỏ hàng?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (rs == DialogResult.OK)
                {
                    //Xóa nếu oke
                    RemoveItem(item.IdManaga);
                    LoadCart();
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            customer = null;
            txtName.Text = "";
            txtAdress.Text = "";
            cbbGioiTinh.SelectedValue = 1;
            btnControl.Text = "Thêm khách hàng";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var item = cartDTOBindingSource.Current as CartDTO;
            if (item != null)
            {
                var managa = ManagaDAO.Instance.getManagaById(item.IdManaga);
                string input = Interaction.InputBox("Nhập số lượng:", "Chỉnh sửa số lượng", "1");
                if (!string.IsNullOrEmpty(input))
                {

                    // Kiểm tra xem số lượng có phải là số nguyên dương hay không
                    if (int.TryParse(input, out int quantity) && quantity > 0)
                    {
                        if (managa.Amount < quantity)
                        {
                            MessageBox.Show("Số lượng truyện không đủ!!!", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        EditItem(item.IdManaga, quantity);
                        LoadCart();
                    }
                }
            }
        }
    }
}
