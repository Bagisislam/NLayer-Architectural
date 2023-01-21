using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductMeneger:IProductService
    {
        private IProductDal _IproductDal;
        public ProductMeneger(IProductDal IproductDal)
        {
            _IproductDal = IproductDal;
        }

        public List<Product> GetAll()
        {
            return _IproductDal.GetAll();
        }

        public List<Product> GetByName(string text)
        {
           return _IproductDal.GetAll(p=>p.ProductName.ToLower().Contains(text.ToLower()));
        }

        public List<Product> SearchByCategoryId(int toInt32)
        {
            
           return _IproductDal.GetAll(p => p.CategoryID == toInt32);
        }

        public void UpdateProduct(Product product)
        {
            _IproductDal.Update(product);
        }

        public void AddProduct(Product product)
        {
            _IproductDal.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                _IproductDal.Delete(product);
            }
            catch (Exception e)
            {
                
                throw new Exception("This Product Could Not Deleted Because İts Still On Sale");
            }
            
        }
    }
}
