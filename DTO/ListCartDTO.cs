using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanTruyen.DTO
{
    public class ListCartDTO
    {
        private static ListCartDTO instance;

        public List<CartDTO> Items { get; set; }

        public ListCartDTO()
        {
            Items = new List<CartDTO>();
        }

        public static ListCartDTO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListCartDTO();
                }
                return instance;
            }
        }

        public void AddItem(CartDTO item)
        {
            var existingItem = Items.FirstOrDefault(i => i.IdManaga == item.IdManaga);

            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }

        public void RemoveItem(int IdManaga)
        {
            var itemToRemove = Items.FirstOrDefault(i => i.IdManaga == IdManaga);

            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }

        public long CalculateTotal()
        {
            return Items.Sum(item => item.Subtotal);
        }
    }
}
