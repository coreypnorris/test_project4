using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Models
{
    public class Issue
    {
        public int IssueId { get; set; }
        public int? Number { get; set; }

        public int TitleId { get; set; }
        public virtual Title Title { get; set; }
    }
}