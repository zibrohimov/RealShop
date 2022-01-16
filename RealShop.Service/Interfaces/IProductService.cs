using RealShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealShop.Service.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetById(int id);
    }
}
