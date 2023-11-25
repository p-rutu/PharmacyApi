using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyUpdated.Models
{
    public partial class User
    {
        //public User()
        //{
        //    FinalDbs = new HashSet<FinalDb>();
        //}

        public int UserId { get; set; }
        public string UserName { get; set; }
        public long? UserContact { get; set; }
        public string UserAddress { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        //public virtual ICollection<FinalDb> FinalDbs { get; set; }
    }
}
