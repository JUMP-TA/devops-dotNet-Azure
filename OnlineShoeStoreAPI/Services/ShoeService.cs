using OnlineShoeStoreAPI.Models;
using System.Collections.Generic;
namespace OnlineShoeStoreAPI.Services
{
    public class ShoeService
    {
        private readonly List<Shoe> _shoes;

        public ShoeService()
        {
            _shoes = new List<Shoe>
            {
                new Shoe { Id = 1, Name = "Running Sneakers", Brand = "Nike", Price = 99.99m, Stock = 10 },
                new Shoe { Id = 2, Name = "Basketball Shoes", Brand = "Adidas", Price = 129.99m, Stock = 5 },
                new Shoe { Id = 3, Name = "Work Shoes", Brand = "Carhart", Price = 129.99m, Stock = 5 }
            };
        }

        public IEnumerable<Shoe> GetAllShoes()
        {
            return _shoes;
        }

        public Shoe GetShoeById(int id)
        {
            return _shoes.FirstOrDefault(shoe => shoe.Id == id);
        }
    }
}