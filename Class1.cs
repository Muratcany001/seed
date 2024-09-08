using Code_First;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
//EcommerceDbContext context = new(); //connection classı
//await context.Database.MigrateAsync(); //sync işlemi

//Products product = new Products()
//{
//    Name = "Test2",//veri girişi
//    Stock = 10
//};
//await context.Products.AddAsync(product); //ekleme
//await context.SaveChangesAsync(); //execute
//public DbSet<Products> Product { get; set; }

namespace Code_First
{

    internal class EcommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=DESKTOP-KP4MLAD\\MURAT;initial catalog=muratdb;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) ////////////////////SEED
        {
            base.OnModelCreating(modelBuilder);

            // Seed verileri ekleme
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 2, Name = "Test2", Stock = 1 },
                new Product { Id = 3, Name = "Test3", Stock = 2 },
                new Product { Id = 4, Name = "Test4", Stock = 3 },
                new Product { Id = 5, Name = "Test5", Stock = 4 }
            );
        } }

    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
    }
}
