﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Models
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }
    }
}