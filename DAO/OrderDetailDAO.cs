using QuanLyBanTruyen.DTO;
using QuanLyBanTruyen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;

namespace QuanLyBanTruyen.DAO
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderDetailDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<OrderDetailDTO> getList(int OrderID)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = from orderdetail in managaDB.OrderDetails
                             join managa in managaDB.Managas
                             on orderdetail.IdManaga equals managa.Id
                             where (orderdetail.IdOrder == OrderID)
                             select new OrderDetailDTO
                             {
                                 Id = orderdetail.Id,
                                 IdOrder = orderdetail.IdOrder,
                                 IdManaga = orderdetail.IdManaga,
                                 NameManaga = managa.Title,
                                 Amount = orderdetail.Amount,
                                 TotalPrice = orderdetail.TotalPrice,
                             };

                // result là danh sách OrderDetailDTO
                return result.ToList();
            }
        }

        public void AddOrderDetails(List<CartDTO> items, int orderId)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                foreach (var item in items)
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        IdOrder = orderId,
                        IdManaga = item.IdManaga,
                        Amount = item.Quantity,
                        TotalPrice = item.Subtotal,
                    };

                    managaDB.OrderDetails.Add(orderDetail);
                    var managa = managaDB.Managas.Where(t => t.Id == item.IdManaga).FirstOrDefault();
                    if (managa != null)
                    {
                        managa.Amount -= item.Quantity;
                    }

                }
                managaDB.SaveChanges();
            }
        }

        public void EditOrderDetail(int Id, int IdOrder, int IdManaga, int Amount, long TotalPrice)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var orderDetail = managaDB.OrderDetails.Where(t => t.Id == Id).FirstOrDefault();
                if (orderDetail != null)
                {
                    orderDetail.IdOrder = IdOrder;
                    orderDetail.IdManaga = IdManaga;
                    orderDetail.Amount = Amount;
                    orderDetail.TotalPrice = TotalPrice;
                    managaDB.SaveChanges();
                }
            }
        }

        public void DeleteOrderDetail(int orderDetailId)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                // Lấy thông tin chi tiết hóa đơn để kiểm tra IdOrder
                var orderDetail = managaDB.OrderDetails.Where(m => m.Id == orderDetailId).FirstOrDefault();

                if (orderDetail != null)
                {
                    // Lấy thông tin chi tiết hóa đơn để cập nhật số lượng vào Managa
                    var managa = managaDB.Managas.Where(m => m.Id == orderDetail.IdManaga).FirstOrDefault();

                    // Kiểm tra xem có Managa tương ứng không
                    if (managa != null)
                    {
                        // Cộng số lượng vào Managa
                        managa.Amount += orderDetail.Amount;

                    }
                    // Lưu trữ IdOrder trước khi xóa
                    int orderId = orderDetail.IdOrder;

                    // Xóa chi tiết hóa đơn
                    managaDB.OrderDetails.Remove(orderDetail);


                    // Kiểm tra xem còn chi tiết hóa đơn nào của hóa đơn không
                    bool hasOrderDetails = managaDB.OrderDetails.Any(od => od.IdOrder == orderId);

                    // Nếu không còn chi tiết hóa đơn, thì xóa hóa đơn
                    if (!hasOrderDetails)
                    {
                        var orderToRemove = managaDB.Orders.Where(o => o.Id == orderId).FirstOrDefault();
                        if (orderToRemove != null)
                        {
                            managaDB.Orders.Remove(orderToRemove);
                        }
                    }
                    managaDB.SaveChanges();
                }
            }
        }
        public void DeleteOrderDetailsOfOrder(int orderId)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                // Lấy danh sách chi tiết hóa đơn cần xóa
                var orderDetailsToDelete = managaDB.OrderDetails
                    .Where(od => od.IdOrder == orderId)
                    .ToList();

                foreach (var orderDetail in orderDetailsToDelete)
                {
                    // Lấy thông tin chi tiết hóa đơn để cập nhật số lượng vào Managa
                    var managa = managaDB.Managas.Where(m => m.Id == orderDetail.IdManaga).FirstOrDefault();

                    // Kiểm tra xem có Managa tương ứng không
                    if (managa != null)
                    {
                        // Cộng số lượng vào Managa
                        managa.Amount += orderDetail.Amount;

                        // Xóa chi tiết hóa đơn
                        managaDB.OrderDetails.Remove(orderDetail);
                    }
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                managaDB.SaveChanges();
            }
        }
    }
}
