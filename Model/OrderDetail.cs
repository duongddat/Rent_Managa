using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.Model
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdManaga { get; set; }
        public int Amount { get; set; }
        public long TotalPrice { get; set; }

        [ForeignKey("IdOrder")]
        public virtual Order Order { get; set; }
        [ForeignKey("IdManaga")]
        public virtual Managa Managa { get; set; }
    }
}
