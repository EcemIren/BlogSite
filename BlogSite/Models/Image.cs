using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class Image
    {
        public Image()
        {
            this.Authors = new List<Author>();
            this.Journals = new List<Journal>();
        }

        public int ImageId { get; set; }
        public string SmallSize { get; set; }
        public string MediumSize { get; set; }
        public string BigSize { get; set; }
        public string Video { get; set; }
        public Nullable<int> MakaleId { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual Journal Journal { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
