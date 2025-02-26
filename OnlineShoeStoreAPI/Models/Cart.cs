using System.Collections.Generic;
using System.Linq;
using OnlineShoeStoreAPI.Models;

namespace OnlineShoeStoreAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Shoe> Items { get; set; }

        public Cart()
        {
            Items = new List<Shoe>();
        }

        public void AddItem(Shoe shoe)
        {
            Items.Add(shoe);
        }

        public void RemoveItem(int shoeId)
        {
            Items.RemoveAll(s => s.Id == shoeId);
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(s => s.Price);
        }
    }
}