using Microsoft.EntityFrameworkCore;
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
    public class ManagaDAO
    {
        private static ManagaDAO instance;
        public static ManagaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagaDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ManagaDAO() { }
        public List<ManagaDTO> getListManaga()
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = from managa in managaDB.Managas
                             join category in managaDB.Categories
                             on managa.IdCategory equals category.Id
                             select new ManagaDTO
                             {
                                 Id = managa.Id,
                                 Title = managa.Title,
                                 Author = managa.Author,
                                 Amount = managa.Amount,
                                 Price = managa.Price,
                                 Image = managa.Image,
                                 IdCategory = managa.IdCategory,
                                 CategoryName = category.Title
                             };

                // result là danh sách ManagaDTO
                return result.ToList();
            }
        }

        public List<ManagaDTO> searchManaga(string searchTerm)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = from managa in managaDB.Managas
                             join category in managaDB.Categories
                             on managa.IdCategory equals category.Id
                             where (
                                    managa.Title.ToLower().Contains(searchTerm) ||
                                    category.Title.ToLower().Contains(searchTerm) ||
                                    managa.Author.ToLower().Contains(searchTerm)
                             )
                             select new ManagaDTO
                             {
                                 Id = managa.Id,
                                 Title = managa.Title,
                                 Author = managa.Author,
                                 Amount = managa.Amount,
                                 Price = managa.Price,
                                 Image = managa.Image,
                                 IdCategory = managa.IdCategory,
                                 CategoryName = category.Title
                             };

                // result là danh sách ManagaDTO
                return result.ToList();
            }

        }

        public List<ManagaDTO> filterManaga(CategoryDTO c)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var result = from managa in managaDB.Managas
                             join category in managaDB.Categories
                             on managa.IdCategory equals category.Id
                             where (managa.IdCategory == c.Id)
                             select (new ManagaDTO
                             {
                                 Id = managa.Id,
                                 Title = managa.Title,
                                 Author = managa.Author,
                                 Amount = managa.Amount,
                                 Price = managa.Price,
                                 Image = managa.Image,
                                 IdCategory = managa.IdCategory,
                                 CategoryName = category.Title
                             });

                return result.ToList();
            }    
        }
        public Managa getManagaById(int Id)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var managa = managaDB.Managas.Where(m => m.Id == Id).FirstOrDefault();
                return managa;
            }
        }

        public Managa getManagaByName(string Name)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var managa = managaDB.Managas.Where(m => m.Title.ToLower().Equals(Name.ToLower())).FirstOrDefault();
                return managa;
            }
        }

        public void AddManaga(Managa managa)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                managaDB.Managas.Add(managa);
                managaDB.SaveChanges();
            }
        }

        public void EditManaga(int Id, string tenTruyen, string tacGia, int soLuong, long gia, string anh, int idLoai)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var managa = managaDB.Managas.Where(t => t.Id == Id).FirstOrDefault();
                if(managa != null)
                {
                    managa.Title = tenTruyen;
                    managa.Author = tacGia;
                    managa.Amount = soLuong;
                    managa.Price = gia;
                    managa.Image = anh;
                    managa.IdCategory = idLoai;

                    managaDB.SaveChanges();
                }
            }
        }

        public void DeleteManaga(int Id)
        {
            using (ManagaDB managaDB = new ManagaDB())
            {
                var managa = managaDB.Managas.Where(m => m.Id == Id).FirstOrDefault();
                if (managa != null)
                {
                    managaDB.Managas.Remove(managa);
                    managaDB.SaveChanges();
                }
            }
        }
    }
}
