using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyUpdated.Models
{
    public partial class FinalDb
    {
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? DrugId { get; set; }
        public string DrugName { get; set; }
        public int? Quantity { get; set; }
        public double? TotalPrice { get; set; }
        public DateTime? DrugExp { get; set; }
        public string OrderDate { get; set; }
        public string UserEmail { get; set; }
        public double? Price { get; set; }
        public string IsPicked { get; set; }

        //public virtual Drug Drug { get; set; }
        //public virtual User User { get; set; }
    }
}
