using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsMVC.Models;

namespace ProductsMVC
{
    public interface IRepository
    {
        List<Product> GetList();
        Product GetProductById(int ID);
    }
}
