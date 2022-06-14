using Microsoft.EntityFrameworkCore;
using DevExp.EntityFramework.Models;

namespace DevExp.EntityFramework
{
    public class DEContext:DbContext
    {
        public DEContext(DbContextOptions<DEContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer() {Id=1, Name = "Murat" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 2, Name = "Bülent" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 3, Name = "Özgür" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 4, Name = "Ahmet" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 5, Name = "Hüseyin" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 6, Name = "Can" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 7, Name = "Buğra" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 8, Name = "Duygu" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 9, Name = "İlkem" });
            modelBuilder.Entity<Product>().HasData(new Product() {ProductId=1, ProductName = "Halley",UnitPrice=50});
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 2, ProductName = "Lays" ,UnitPrice=150});
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 3, ProductName = "Ruffles",UnitPrice=150 });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 4, ProductName = "Eti Karam" , UnitPrice = 80 });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 5, ProductName = "Eti Ahenk",UnitPrice=80 });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 6, ProductName = "Sütaş Süt",UnitPrice=180 });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 7, ProductName = "Cartedor Bademli Magnum",UnitPrice=200 });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 8, ProductName = "Algida Maraş Usulü",UnitPrice=200 });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 9, ProductName = "Coca Cola",UnitPrice=100 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() {Id=1, BuyedUnitAmount=1,ProductId=1,CustomerId=1});
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 2, BuyedUnitAmount = 2, ProductId = 2, CustomerId = 2 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 3, BuyedUnitAmount = 3, ProductId = 3, CustomerId = 3 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 4, BuyedUnitAmount = 4, ProductId = 4, CustomerId = 4 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 5, BuyedUnitAmount = 2, ProductId = 5, CustomerId = 5 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 6, BuyedUnitAmount = 1, ProductId = 6, CustomerId = 6 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 7, BuyedUnitAmount = 1, ProductId = 7, CustomerId = 7 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 8, BuyedUnitAmount = 3, ProductId = 8, CustomerId = 8 });
            modelBuilder.Entity<ProductSale>().HasData(new Models.ProductSale() { Id = 9, BuyedUnitAmount = 2, ProductId = 9, CustomerId = 9 });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductSale> ProductSale { get; set; }

    }
}
