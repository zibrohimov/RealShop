using RealShop.Data.Interfaces;
using RealShop.Domain;

namespace RealShop.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category GetById(int id)
        {
            return new Category
            {
                Id = id,
                Name = $"Category - {id}"
            };
        }
    }
}
