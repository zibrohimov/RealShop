using RealShop.Domain;

namespace RealShop.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfProducts { get; set; }

        public static explicit operator CategoryViewModel(Category product)
        {
            return new CategoryViewModel
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
