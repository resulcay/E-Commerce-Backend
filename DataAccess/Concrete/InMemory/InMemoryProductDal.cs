using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {

         // Burası fake bir veritabanı görünümüdür.(Sql Server, Oracle, Postgres, MongoDB vb.).

            _products = new List<Product>()
            {
               new Product { ProductId=1, ProductName="Bardak", CategoryId=1, UnitsInStock=15, UnitPrice=15 },
               new Product { ProductId=2, ProductName="Kamera", CategoryId=1, UnitsInStock=3, UnitPrice=500 },
               new Product { ProductId=3, ProductName="Telefon", CategoryId=2, UnitsInStock=2, UnitPrice=1500 },
               new Product { ProductId=4, ProductName="Klavye", CategoryId=2, UnitsInStock=65, UnitPrice=150 },
               new Product { ProductId=5, ProductName="Fare", CategoryId=2, UnitsInStock=1, UnitPrice=85 },
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        product = productToDelete;
            //    }
            //}    

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            //Yukarıdaki atama foreach'de yaptığımız operasyonla aynıdır.

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
