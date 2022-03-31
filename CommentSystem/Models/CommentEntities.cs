using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommentSystem.Models
{
    public partial class CommentEntities : DbContext
    {
        public CommentEntities()
            : base("name=CommentEntities")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
    }
}