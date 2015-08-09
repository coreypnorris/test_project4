namespace PublicComics.Web.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PublicComics.Web.Infrastructure.PublicComicsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PublicComics.Web.Infrastructure.PublicComicsDb context)
        {
            context.Titles.AddOrUpdate(t => t.Name,
                    new Title() { Name = "Action Comics" },
                    new Title() { Name = "Detective Comics" },
                    new Title() { Name = "Fantastic Four" },
                    new Title() { Name = "Amazing Spider-Man" }
            );
        }
    }
}
