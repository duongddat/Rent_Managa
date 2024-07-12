using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.Model
{
    public class ManagaDB : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Managa> Managas { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine("E:", "managa.db");
            var conString = $"Data source={path}";
            optionsBuilder.UseSqlite(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Category
            Category category1 = new Category
            {
                Id = 1,
                Title = "Hành động"
            };
            Category category2 = new Category
            {
                Id = 2,
                Title = "Hài"
            };
            Category category3 = new Category
            {
                Id = 3,
                Title = "Khoa học viễn tưởng"
            };

            //Employee
            Employee employee = new Employee
            { 
                Id = 1,
                Name = "Admin",
                Phone = "111111111",
                Adress = "Huế",
                GioiTinh = 1,
                password = "123",
                isAdmin = true,
            };


            modelBuilder.Entity<Category>().HasData(category1, category2, category3);
            modelBuilder.Entity<Employee>().HasData(employee);
        }
    }
}
