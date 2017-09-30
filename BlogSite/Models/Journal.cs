using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class Journal
    {
        public Journal()
        {
            this.Comments = new List<Comment>();
            this.Tags = new List<Tag>();
        }

        public int JournalId { get; set; }
        public string Title { get; set; }
        public string ContentPart { get; set; }
        public System.DateTime CreationDate { get; set; }
        public int CategoryId { get; set; }
        public int DisplayCount { get; set; }
        public int LikeCount { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
