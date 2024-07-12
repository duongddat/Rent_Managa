using Microsoft.EntityFrameworkCore;
using QuanLyBanTruyen.DTO;
using QuanLyBanTruyen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<OrderDTO> getList(int EmployeeId, bool isAdmin)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var query = from c in managaDB.Customers
                            join o in managaDB.Orders on c.Id equals o.CustomerId
                            join e in managaDB.Employees on o.EmployeeId equals e.Id
                            join od in managaDB.OrderDetails on o.Id equals od.IdOrder
                            where (isAdmin || o.EmployeeId == EmployeeId)
                            group new { o, c, e, od } by new
                            {
                                o.Id,
                                o.OrderDate,
                                o.CustomerId,
                                NameCustomer = c.Name,
                                o.EmployeeId,
                                NameEmployee = e.Name
                            } into grouped
                            select new OrderDTO
                            {
                                Id = grouped.Key.Id,
                                OrderDate = grouped.Key.OrderDate,
                                CustomerId = grouped.Key.CustomerId,
                                CustomerName = grouped.Key.NameCustomer,
                                EmployeeId = grouped.Key.EmployeeId,
                                EmployeeName = grouped.Key.NameEmployee,
                                TotalBillOrder = grouped.Sum(x => x.od.TotalPrice)
                            };

                // Order the results by OrderDate in descending order (you can use OrderBy for ascending order)
                query = query.OrderByDescending(x => x.OrderDate);

                return query.ToList();
            }
        }

        public int AddOrder(Order order)
        {
            int orderId = 0;

            using (ManagaDB managaDB = new ManagaDB())
            {
                managaDB.Orders.Add(order);
                managaDB.SaveChanges();

                // Lấy ID của đơn đặt hàng vừa được tạo
                orderId = order.Id;
            }

            return orderId;
        }

        public void EditOrder(int Id, DateTime OrderDate, int CustomerId, int EmployeeId)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var order = managaDB.Orders.Where(t => t.Id == Id).FirstOrDefault();
                if (order != null)
                {
                    order.OrderDate = OrderDate;
                    order.CustomerId = CustomerId;
                    order.EmployeeId = EmployeeId;
                    managaDB.SaveChanges();
                }
            }
        }

        public void DeleteOrder(int Id)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var order = managaDB.Orders.Where(m => m.Id == Id).FirstOrDefault();
                if (order != null)
                {
                    managaDB.Orders.Remove(order);
                    managaDB.SaveChanges();
                }
            }
        }

        public void DeleteOrderAndDetails(int OrderID)
        {

            // Xóa tất cả chi tiết hóa đơn của hóa đơn
            OrderDetailDAO.Instance.DeleteOrderDetailsOfOrder(OrderID);

            // Xóa hóa đơn chính
            DeleteOrder(OrderID);
        }

        public List<int> ListYearRevenue()
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var namList = managaDB.Orders
                    .OrderByDescending(g => g.OrderDate.Year)
                    .Select(o => o.OrderDate.Year)
                    .Distinct()
                    .OrderByDescending(year => year)
                    .ToList();

                return namList;
            }
        }

        public List<ThongKeDTO> ThongKeDoanhThuTheoNam(int nam)
        {
            /*using (ManagaDB managaDB = new ManagaDB())
            {
                var result = from o in managaDB.Orders
                             join od in managaDB.OrderDetails
                             on o.Id equals od.IdOrder
                             where (o.OrderDate.Year == nam)
                             group od by o.OrderDate.Month into g
                             select new ThongKeDTO
                             {
                                 Thang = g.Key,
                                 DoanhThu = g.Sum(od => od.TotalPrice)
                             };

                return result.ToList();
            }*/
            using (ManagaDB managaDB = new ManagaDB())
            {
                int endMonth = (nam == DateTime.Now.Year) ? DateTime.Now.Month : 12;

                var result = from month in Enumerable.Range(1, endMonth)
                             join o in managaDB.Orders.Where(o => o.OrderDate.Year == nam)
                                on month equals (o != null ? o.OrderDate.Month : 0) into monthOrders
                             from o in monthOrders.DefaultIfEmpty()
                             join od in managaDB.OrderDetails
                                on o != null ? o.Id : 0 equals od.IdOrder into orderDetailsGroup
                             group orderDetailsGroup by month into g
                             select new ThongKeDTO
                             {
                                 Thang = g.Key,
                                 DoanhThu = g.Any() ? g.Sum(monthDetails => monthDetails.Sum(od => od.TotalPrice)) : 0
                             };

                return result.ToList();
            }
        }
    }
}
