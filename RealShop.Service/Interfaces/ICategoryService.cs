using RealShop.ViewModel;

namespace RealShop.Service.Interfaces
{
    public interface ICategoryService
    {
        CategoryViewModel GetById(int id);
    }
}
