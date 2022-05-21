using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {

        // SOLID
        // Open Closed Principle

        static void Main(string[] args)
        {
            ProductTest();

            // CategoryTest();

        }

        private static void CategoryTest()
        {
            EfCategoryDal efCategoryDal = new EfCategoryDal();

            CategoryService categoryService = new CategoryService(efCategoryDal);

            foreach (var c in efCategoryDal.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }
        }

        private static void ProductTest()
        {
            InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            EfProductDal efProductDal = new EfProductDal();

            //  ProductService productManager = new ProductService(efProductDal);

            // var result = productManager.GetProductDetails();

            //if (result.Success == true)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            //    }

            //    Console.WriteLine("\n" + result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }
    }
}