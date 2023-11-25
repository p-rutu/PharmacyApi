using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyUpdated.Models
{
    public partial class Supplier
    {
        //public Supplier()
        //{
        //    Drugs = new HashSet<Drug>();
        //}

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public long? SupplierContact { get; set; }

        //public virtual ICollection<Drug> Drugs { get; set; }
    }
}
