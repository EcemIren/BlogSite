using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Journals = new List<Journal>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
