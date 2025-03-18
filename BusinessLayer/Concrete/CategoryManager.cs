using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TAdd(Category p)
        {
            _categoryDal.Insert(p);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(x => x.CategoryId == id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.List();
        }

        public void TRemove(Category p)
        {
            _categoryDal.Remove(p);
        }

        public void TUpdate(Category p)
        {
            _categoryDal.Update(p);
        }
    }
}
