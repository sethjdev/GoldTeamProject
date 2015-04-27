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
            context.Products.AddOrUpdate(
                p => p.Title,
                new Product { Title = "Product 1" },
                new Product { Title = "Product 2" },
                new Product { Title = "Product 3" },
                new Product { Title = "Product 4" },
                new Product { Title = "Product 5" }
                );


        }
    }
}
