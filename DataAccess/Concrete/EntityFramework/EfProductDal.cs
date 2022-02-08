using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using kullanmak daha mantıklı, çünkü bellekten daha sonra silme işlemi yapar. 
            //IDisposable pattern implementation of C#.

            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntities = context.Entry(entity);
                addedEntities.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntities = context.Entry(entity);
                deletedEntities.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntities = context.Entry(entity);
                updatedEntities.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            //Tek data getirirken...

            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            //Tüm dataları getirirken...

            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        
    }
}
