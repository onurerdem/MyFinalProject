using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş kodları
            //throw new NotImplementedException();
            return _categoryDal.GetAll();
        }

        //Select * from Categories where CategoryId = 3
        public Category GetById(int categoryId)
        {
            //throw new NotImplementedException();
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
