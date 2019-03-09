using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsMVC.Models;

namespace ProductsMVC
{
    public class Repository : IRepository
    {
        private List<Product> ProductList;

        public Repository()
        {
            ProductList = new List<Product>()
            {
                new Product { ID = 1, Name = "Chai", Category="Bevarages", Price=(decimal)18.00, UnitsInStock=39 },
                new Product { ID = 2, Name = "Chang", Category="Bevarages", Price=(decimal)19.00, UnitsInStock=17 },
            };
        }

        public List<Product> GetList()
        {
            return ProductList;
        }

        public Product GetProductById(int ID)
        {
            return ProductList.Find(p => p.ID == ID);
        }
    }
}
