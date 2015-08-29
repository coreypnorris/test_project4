using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Models
{
    public class Comment
    {
        public Comment()
        {
            CreatedOn = DateTime.Now;
            SubComments = new List<Comment>();
        }

        public int CommentID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }

        public string Body { get; set; }
        public string Author { get; set; }

        public int? ParentCommentID { get; set; }

        [ForeignKey("ParentCommentID")]
        public virtual Comment ParentComment { get; set; }

        [InverseProperty("ParentComment")]
        public virtual ICollection<Comment> SubComments { get; set; }
    }
}