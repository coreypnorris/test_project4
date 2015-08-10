namespace PublicComics.Web.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PublicComics.Web.Infrastructure.PublicComicsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PublicComics.Web.Infrastructure.PublicComicsDb context)
        {
            var ActionComics = new Title() { TitleId = 1 , Name = "Action Comics"};
            context.Titles.AddOrUpdate(ActionComics);
            context.SaveChanges();

            var ActionComicsIssueOne = new Issue() { IssueId = 1, Number = 1, TitleId = 1 };
            context.Issues.AddOrUpdate(ActionComicsIssueOne);
            context.SaveChanges();

            var DetectiveComics = new Title() { TitleId = 2, Name = "Detective Comics" };
            context.Titles.AddOrUpdate(DetectiveComics);
            context.SaveChanges();

            var DetectiveComicsIssueTwentySeven = new Issue() { IssueId = 2, Number = 27, TitleId = 2 };
            context.Issues.AddOrUpdate(DetectiveComicsIssueTwentySeven);
            context.SaveChanges();            
        }
    }
}
