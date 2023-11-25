using PharmacyUpdated.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyUpdated.Repository
{
    public interface ISuppllier
    {

        public List<Supplier> GetAllSupplier();
        public Supplier GetSupplierById(int id);
        public string UpdateSupplier( Supplier supplier);
        public string CreateSupplier(Supplier supplier);
        public string DeleteSupplierById(int id);
    }
}
