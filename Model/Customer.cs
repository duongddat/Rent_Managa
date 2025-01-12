﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.Model
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Adress { get; set; }
        public int GioiTinh { get; set; }
    }
}
