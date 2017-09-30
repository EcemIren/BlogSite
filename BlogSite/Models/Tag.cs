using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class Tag
    {
        public Tag()
        {
            this.Journals = new List<Journal>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
