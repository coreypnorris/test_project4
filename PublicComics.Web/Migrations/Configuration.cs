namespace PublicComics.Web.Migrations
{
    using Models;
    using System;
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
            var Title = new Title()
            {
                TitleID = 1,
                Name = "Captain Marvel Adventures",
                LastModified = DateTime.Now
            };
            context.Titles.AddOrUpdate(Title);
            
            var Issue = new Issue()
            {
                IssueID = 1,
                Number = 20,
                LastModified = DateTime.Now
            };
            context.Issues.AddOrUpdate(Issue);
            Title.Issues.Add(Issue);
            
            var CommentOne = new Comment()
            {
                CommentID = 1,
                Author = "Troll 1",
                Body = "I hated this issue.",
                LastModified = DateTime.Now
            };

            var CommentTwo = new Comment()
            {
                CommentID = 2,
                Author = "Troll 2",
                Body = "I liked this issue.",
                LastModified = DateTime.Now
            };

            Issue.Comments.Add(CommentOne);
            Issue.Comments.Add(CommentTwo);
            
            var CommentThree = new Comment()
            {
                CommentID = 3,
                Author = "Troll 3",
                Body = "I hated this comment.",
                LastModified = DateTime.Now
            };

            var CommentFour = new Comment()
            {
                CommentID = 4,
                Author = "Troll 4",
                Body = "I liked this comment.",
                LastModified = DateTime.Now
            };

            var CommentFive = new Comment()
            {
                CommentID = 5,
                Author = "Troll 5",
                Body = "I hated this subcomment.",
                LastModified = DateTime.Now
            };


            var CommentSix = new Comment()
            {
                CommentID = 6,
                Author = "Troll 6",
                Body = "I liked this subcomment.",
                LastModified = DateTime.Now
            };

            Issue.Comments.Add(CommentThree);
            Issue.Comments.Add(CommentFour);
            Issue.Comments.Add(CommentFive);
            Issue.Comments.Add(CommentSix);

            CommentOne.SubComments.Add(CommentThree);
            CommentTwo.SubComments.Add(CommentFour);
            CommentThree.SubComments.Add(CommentFive);
            CommentFour.SubComments.Add(CommentSix);
            
            foreach (int i in Enumerable.Range(1, 68))
            {
                var Page = new Page() { PageID = i, Number = i, ImageUrl = "http://furycomics.com/Captain_Marvel_Adventures/020/i/" + (i - 1).ToString() + ".jpg", LastModified = DateTime.Now };
                context.Pages.AddOrUpdate(Page);
                Issue.Pages.Add(Page);
            }

            var TagOne = new Tag()
            {
                TagID = 1,
                Name = "Superhero",
                LastModified = DateTime.Now
            };
            context.Tags.AddOrUpdate(TagOne);
            Issue.Tags.Add(TagOne);
            
            var TagTwo = new Tag()
            {
                TagID = 2,
                Name = "Fawcett",
                LastModified = DateTime.Now
            };
            context.Tags.AddOrUpdate(TagTwo);
            Issue.Tags.Add(TagTwo);
            
            var TagThree = new Tag()
            {
                TagID = 3,
                Name = "1943",
                LastModified = DateTime.Now
            };
            context.Tags.AddOrUpdate(TagThree);
            Issue.Tags.Add(TagThree);

            context.SaveChanges();
        }
    }
}
