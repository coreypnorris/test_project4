using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Models
{
    public class Page
    {
        public Page()
        {
            CreatedOn = DateTime.Now;
        }

        public int PageId { get; set; }
        public string ImageUrl { get; set; }
        public int Number { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }

        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
    }
}