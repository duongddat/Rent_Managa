using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int GioiTinh { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }

        public string DisplayGioiTinh
        {
            get
            {
                return GioiTinh ==  0 ? "Nữ" : GioiTinh ==  1 ? "Nam" : "Khác";
            }
        }
    }
}
