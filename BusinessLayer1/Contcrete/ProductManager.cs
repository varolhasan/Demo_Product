using BusinessLayer1.Abstract;
using DataAccesLayer1.Abstract;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer1.Contcrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public Product TGetById(int id)
        {
            return _ProductDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _ProductDal.GetList();
        }

        public void TDelete(Product t)
        {
            _ProductDal.Delete(t);
        }

        public void TInsert(Product t)
        {
            _ProductDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _ProductDal.Update(t);
        }
    }
}
