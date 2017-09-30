using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public int JournalId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string NameSurname { get; set; }
        public Nullable<int> LikeCount { get; set; }
        public virtual Journal Journal { get; set; }
    }
}
