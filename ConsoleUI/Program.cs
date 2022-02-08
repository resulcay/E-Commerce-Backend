using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {

        //SOLID
        //Open Closed Principle

        static void Main(string[] args)
        {
            InMemoryProductDal inMemoryProductDal=new InMemoryProductDal();
            EfProductDal efProductDal = new EfProductDal();

            ProductManager productManager = new ProductManager(efProductDal);

            foreach (var product in productManager.GetByUnitPrice(10, 40))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}