using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryService : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal iCategoryDal)
        {
            _categoryDal = iCategoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {

            // Select * from Categories

            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }



        public IDataResult<Category> GetById(int categoryId)
        {


            // Select * from Categories where CategoryId = 3; 

            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}