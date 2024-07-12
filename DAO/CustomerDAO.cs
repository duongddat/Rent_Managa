using QuanLyBanTruyen.DTO;
using QuanLyBanTruyen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public Customer getCustomerByPhone(string Phone)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var customer = managaDB.Customers.Where(m => m.Phone.Equals(Phone)).FirstOrDefault();
                return customer;
            }
        }

        public List<CustomerDTO> getListCustomer()
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = managaDB.Customers
                            .Select(t => new CustomerDTO
                            {
                                Id = t.Id,
                                Name = t.Name,
                                Phone = t.Phone,
                                Adress = t.Adress,
                                GioiTinh = t.GioiTinh
                            }).ToList();

                return result;
            }
        }

        public List<CustomerDTO> searchCustomer(string searchTerm)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = managaDB.Customers
                             .Where(t =>
                                    t.Name.ToLower().Contains(searchTerm) ||
                                    t.Phone.ToLower().Contains(searchTerm) ||
                                    t.Adress.ToLower().Contains(searchTerm)
                             )
                            .Select(t => new CustomerDTO
                            {
                                Id = t.Id,
                                Name = t.Name,
                                Phone = t.Phone,
                                Adress = t.Adress,
                                GioiTinh = t.GioiTinh
                            }).ToList();

                // result là danh sách CustomerDTO
                return result.ToList();
            }
        }

        public void AddCustomer(Customer customer)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                managaDB.Customers.Add(customer);
                managaDB.SaveChanges();
            }
        }

        public void EditCustomer(int Id, string Name, string Phone, string Adress, int GioiTinh)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var customer = managaDB.Customers.Where(t => t.Id == Id).FirstOrDefault();
                if (customer != null)
                {
                    customer.Name = Name;
                    customer.Phone = Phone;
                    customer.Adress = Adress;
                    customer.GioiTinh = GioiTinh;


                    managaDB.SaveChanges();
                }
            }
        }

        public void DeleteCustomer(int Id)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var customer = managaDB.Customers.Where(m => m.Id == Id).FirstOrDefault();
                if (customer != null)
                {
                    managaDB.Customers.Remove(customer);
                    managaDB.SaveChanges();
                }
            }
        }
    }
}
