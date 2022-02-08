using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
        }

        public void Delete(Category entity)
        {
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return null;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return new List<Category>();
        }

        public void Update(Category entity)
        {
        }
    }
}
