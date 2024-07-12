using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyBanTruyen.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AmountManaga { get; set; }

        public string Display
        {
            get
            {
                return $"{Title} - SL: {AmountManaga}";
            }
        }
    }
}
