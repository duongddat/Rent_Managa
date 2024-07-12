using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DTO
{
    public class CartDTO
    {
        public int IdManaga { get; set; }
        public string NameManaga { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }

        public long Subtotal
        {
            get { return Price * Quantity; }
        }
    }
}
