using RealShop.Data;
using RealShop.Service.Interfaces;
using RealShop.ViewModel;
using System;

namespace RealShop.Service
{
    public class CategoryService : ICategoryService
    {
        public CategoryViewModel GetById(int id)
        {
            var categoryRepository = new CategoryRepository();

            var category = (CategoryViewModel)categoryRepository.GetById(id);

            category.NumberOfProducts = new Random().Next(1, 1000);

            return category;
        }
    }
}
