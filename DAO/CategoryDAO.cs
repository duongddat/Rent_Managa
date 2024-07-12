using Microsoft.VisualBasic.Logging;
using QuanLyBanTruyen.DTO;
using QuanLyBanTruyen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        public List<CategoryDTO> getListCategory()
        {
            using (ManagaDB db = new ManagaDB())
            {
                var ls = db.Categories.Select(e => new CategoryDTO
                {
                    Id = e.Id,
                    Title = e.Title,
                    AmountManaga = e.Managas.Count()
                }).ToList();

                return ls;
            }    
        }

        public List<CategoryDTO> searchCategory(string searchTerm)
        {
            using (ManagaDB db = new ManagaDB())
            {
                var ls = db.Categories
                    .Where(c => c.Title.ToLower().Contains(searchTerm.ToLower()))
                    .Select(c => new CategoryDTO
                    {
                        Id = c.Id,
                        Title = c.Title,
                        AmountManaga = c.Managas.Count()
                    })
                    .ToList();

                return ls;
            }
                
        }

        public Category getCategoryByTitle(string Title)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var category = managaDB.Categories.Where(m => m.Title.ToLower().Equals(Title.ToLower())).FirstOrDefault();
                return category;
            }
        }

        public void AddCategory(Category category)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                managaDB.Categories.Add(category);
                managaDB.SaveChanges();
            }
        }

        public void EditCategory(int Id, string Title)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var category = managaDB.Categories.Where(t => t.Id == Id).FirstOrDefault();
                if (category != null)
                {
                    category.Title = Title;
                    managaDB.SaveChanges();
                }
            }
        }

        public void DeleteCategory(int Id)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var category = managaDB.Categories.Where(m => m.Id == Id).FirstOrDefault();
                if (category != null)
                {
                    managaDB.Categories.Remove(category);
                    managaDB.SaveChanges();
                }
            }
        }
    }
}
