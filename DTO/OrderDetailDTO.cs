using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DTO
{
    public class OrderDetailDTO
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdManaga { get; set; }
        public string NameManaga { get; set; }
        public int Amount { get; set; }
        public long TotalPrice { get; set; }
    }
}
