namespace GoldTeamProject.Migrations
{
    using GoldTeamProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoldTeamProject.Models.GoldTeamProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GoldTeamProject.Models.GoldTeamProjectContext";
        }

        protected override void Seed(GoldTeamProject.Models.GoldTeamProjectContext context)
        {

            context.Products.AddOrUpdate(x => x.Id,
                new Product { Id = 1, Title = "Product 1", Price = 19.99, Photo = "http://experimentalart.unsw.wikispaces.net/file/view/product.jpg/361156778/product.jpg", Description = "Product 1 Description", Availability = true, Category = "Category1" },
                new Product { Id = 2, Title = "Product 2", Price = 12.99, Photo = "http://experimentalart.unsw.wikispaces.net/file/view/product.jpg/361156778/product.jpg", Description = "Product 2 Description", Availability = true, Category = "Category1" },
                new Product { Id = 3, Title = "Product 3", Price = 13.99, Photo = "http://experimentalart.unsw.wikispaces.net/file/view/product.jpg/361156778/product.jpg", Description = "Product 3 Description", Availability = true, Category = "Category2" },
                new Product { Id = 4, Title = "Product 4", Price = 16.99, Photo = "http://experimentalart.unsw.wikispaces.net/file/view/product.jpg/361156778/product.jpg", Description = "Product 4 Description", Availability = true, Category = "Category2" },
                new Product { Id = 5, Title = "Product 5", Price = 17.99, Photo = "http://experimentalart.unsw.wikispaces.net/file/view/product.jpg/361156778/product.jpg", Description = "Product 5 Description", Availability = true, Category = "Category3" }
                );
        }
    }
}
