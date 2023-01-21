using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByName(string text);
        List<Product> SearchByCategoryId(int toInt32);
        void UpdateProduct(Product product);
        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}
