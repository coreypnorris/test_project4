using PublicComics.Web.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace PublicComics.Web.Infrastructure
{
    public class PublicComicsDb : DbContext
    {
        public PublicComicsDb() :base("DefaultConnection") { }

        public DbSet<Title> Titles { get; set; }
        public DbSet<Issue> Issues { get; set; }
    }
}