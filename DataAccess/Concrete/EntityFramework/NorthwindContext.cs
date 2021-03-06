using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Context :  DB tabloları ile projedeki classları bağlama işlemi(ortamı). 

    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //case-insensitive
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        ////fluent mapping

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("dbo");
        //    modelBuilder.Entity<Car>().ToTable("InstanceTable");
        //    modelBuilder.Entity<Car>().Property(p => p.Id).HasColumnName("InstanceTableId");
        //}

    }
}
