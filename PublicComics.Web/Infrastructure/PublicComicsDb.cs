using PublicComics.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Infrastructure
{
    public class PublicComicsDb : DbContext, ITitleDataSource
    {
        public PublicComicsDb() :base("DefaultConnection")
        {

        }

        public DbSet<Title> Titles { get; set; }

        IQueryable<Title> ITitleDataSource.Titles
        {
            get { return Titles; }
        }
    }
}