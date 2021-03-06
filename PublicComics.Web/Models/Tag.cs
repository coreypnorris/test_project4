﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Models
{
    public class Tag
    {
        public Tag()
        {
            CreatedOn = DateTime.Now;
        }

        public int TagID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }

        public int IssueID { get; set; }
        public virtual Issue Issue { get; set; }
    }
}