using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DTO
{
    public class ManagaDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Amount { get; set; }
        public long Price { get; set; }
        public string? Image { get; set; }
        public int IdCategory { get; set; }
        public string CategoryName { get; set; }
    }
}
