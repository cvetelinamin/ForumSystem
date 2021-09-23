﻿namespace ForumSystem.Data.Models
{
    using System.Collections.Generic;

    using ForumSystem.Data.Common.Models;

    public class Post : BaseDeletableModel<int>
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UseriD { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
