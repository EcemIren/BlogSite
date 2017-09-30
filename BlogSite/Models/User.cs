using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class User
    {
        public User()
        {
            this.Authors = new List<Author>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string MailAddress { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
