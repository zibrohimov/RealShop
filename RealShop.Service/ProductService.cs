using RealShop.Data;
using RealShop.Service.Interfaces;
using RealShop.ViewModel;
using System;

namespace RealShop.Service
{
    public class ProductService : IProductService
    {
        public ProductViewModel GetById(int id)
        {
            var productRepository = new ProductRepository();

            var product = (ProductViewModel)productRepository.GetById(id);

            return product;
        }
    }
}
