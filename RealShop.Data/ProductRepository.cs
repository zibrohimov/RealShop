using RealShop.Data.Interfaces;
using RealShop.Domain;
using System;

namespace RealShop.Data
{
    public class ProductRepository : IProductRepository
    {
        public Product GetById(int id)
        {
            return new Product
            {
                Id = id,
                Name = $"Product - {id}",
                CategoryId = new Random().Next(1, 1000)
            };
        }
    }
}
