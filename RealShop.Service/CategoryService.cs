using RealShop.Data;
using RealShop.Service.Interfaces;
using RealShop.ViewModel;

namespace RealShop.Service
{
    public class CategoryService : ICategoryService
    {
        public CategoryViewModel GetById(int id)
        {
            var categoryRepository = new CategoryRepository();

            var category = (CategoryViewModel)categoryRepository.GetById(id);

            return category;
        }
    }
}
