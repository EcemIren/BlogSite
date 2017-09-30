using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class Author
    {
        public Author()
        {
            this.Journals = new List<Journal>();
            this.Users = new List<User>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MailAdres { get; set; }
        public string Detail { get; set; }
        public Nullable<bool> Gender { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
