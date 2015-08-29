using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Models
{
    public class Title
    {
        public Title()
        {
            CreatedOn = DateTime.Now;
            Issues = new List<Issue>();
        }

        public int TitleID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }
    }
}