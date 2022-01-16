using RealShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealShop.Data.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
    }
}
