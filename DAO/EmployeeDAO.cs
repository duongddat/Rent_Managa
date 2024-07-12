using QuanLyBanTruyen.DTO;
using QuanLyBanTruyen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyBanTruyen.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        { 
            get { 
                if (instance == null) 
                    instance = new EmployeeDAO();   
                return instance; 
            } 
            private set { instance = value; }
        }

        private EmployeeDAO() { }

        /*        public bool Login (string phoneNumber, string passWord)
                {
                    ManagaDB managaDB = new ManagaDB();
                    return managaDB.Employees
                        .Any(
                            e => e.Phone.CompareTo(phoneNumber) == 0 && 
                            e.password.CompareTo(passWord) == 0
                        );

                }*/

        public Employee getEmployeeByPhone(string Phone)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var employee = managaDB.Employees.Where(m => m.Phone.Equals(Phone)).FirstOrDefault();
                return employee;
            }
        }

        public EmployeeDTO GetAccout(string phoneNumber, string passWord)
        {
            using(ManagaDB managaDB = new ManagaDB())
            {
                var account = managaDB.Employees
                    .Where(t => t.Phone == phoneNumber && t.password == passWord)
                    .Select(t => new EmployeeDTO
                    {
                        Id = t.Id,
                        Name = t.Name,
                        Phone = t.Phone,
                        Adress = t.Adress,
                        GioiTinh = t.GioiTinh,
                        Password = t.password,
                        isAdmin = t.isAdmin,
                    })
                    .FirstOrDefault();

                return account;
            }      
        }

        public bool ChangePassword(int Id, string Phone, string Password)
        {
            using(ManagaDB managaDB = new ManagaDB())
            {
                var account = managaDB.Employees.Where(t => t.Id == Id && t.Phone.Equals(Phone)).FirstOrDefault();
                if (account != null)
                {
                    
                    account.password = Password;

                    managaDB.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public List<EmployeeDTO> getListEmployee()
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = managaDB.Employees
                            .Where(t => t.isAdmin != true)
                            .Select(t => new EmployeeDTO
                             {
                                Id = t.Id,
                                Name = t.Name,
                                Phone = t.Phone,
                                Adress = t.Adress,
                                GioiTinh = t.GioiTinh,
                                Password = t.password,
                                isAdmin = t.isAdmin
                            }).ToList();

                return result;
            }
        }

        public List<EmployeeDTO> searchEmployee(string searchTerm)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = managaDB.Employees
                             .Where(t =>
                                    (t.Name.ToLower().Contains(searchTerm.ToLower()) ||
                                    t.Phone.ToLower().Contains(searchTerm.ToLower()) ||
                                    t.Adress.ToLower().Contains(searchTerm.ToLower())) &&
                                    t.isAdmin != true
                             )
                            .Select(t => new EmployeeDTO
                            {
                                Id = t.Id,
                                Name = t.Name,
                                Phone = t.Phone,
                                Adress = t.Adress,
                                GioiTinh = t.GioiTinh,
                                Password = t.password,
                                isAdmin = t.isAdmin
                            }).ToList();

                // result là danh sách EmployeeDTO
                return result.ToList();
            }
        }

        public void AddEmloyee(Employee employee)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                managaDB.Employees.Add(employee);
                managaDB.SaveChanges();
            }
        }

        public void EditEmployee(int Id, string Name, string Phone, string Adress, int GioiTinh, string Password, bool isAdmin)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var employee = managaDB.Employees.Where(t => t.Id == Id).FirstOrDefault();
                if (employee != null)
                {
                    employee.Name = Name;
                    employee.Phone = Phone;
                    employee.Adress = Adress;
                    employee.GioiTinh = GioiTinh;
                    employee.password = Password;
                    employee.isAdmin = isAdmin;

                    managaDB.SaveChanges();
                }
            }
        }

        public void DeleteEmployee(int Id)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var employee = managaDB.Employees.Where(m => m.Id == Id).FirstOrDefault();
                if (employee != null)
                {
                    managaDB.Employees.Remove(employee);
                    managaDB.SaveChanges();
                }
            }
        }
    }
}
