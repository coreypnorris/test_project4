using PublicComics.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Models
{
    public class Issue
    {
        public Issue()
        {
            CreatedOn = DateTime.Now;
            Pages = new List<Page>();
            Tags = new List<Tag>();
            Comments = new List<Comment>();
        }

        public int IssueID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }

        public int? Number { get; set; }

        public int TitleID { get; set; }
        public virtual Title Title { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
