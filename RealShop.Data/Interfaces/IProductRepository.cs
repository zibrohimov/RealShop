using RealShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealShop.Data.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);
    }
}
