using RealShop.Domain;

namespace RealShop.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }

        public static explicit operator ProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                CategoryId = product.CategoryId
            };
        }

        public static explicit operator Product(ProductViewModel product)
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
