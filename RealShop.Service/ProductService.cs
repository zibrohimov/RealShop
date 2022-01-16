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

            var categoryService = new CategoryService();

            var product = (ProductViewModel)productRepository.GetById(id);

            product.Category = categoryService.GetById(product.CategoryId);

            return product;
        }
    }
}
