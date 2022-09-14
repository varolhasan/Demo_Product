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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _ICategoryDal;

        public CategoryManager(ICategoryDal ıCategoryDal)
        {
            _ICategoryDal = ıCategoryDal;
        }

        public Category TGetById(int id)
        {
            return _ICategoryDal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _ICategoryDal.GetList();
        }

        public void TDelete(Category t)
        {
            _ICategoryDal.Delete(t);
        }

        public void TInsert(Category t)
        {
            _ICategoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _ICategoryDal.Update(t);
        }
    }
}
