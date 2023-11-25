
using pharamcy.Repositere;
using PharmacyUpdated.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pharamcy.Services
{
    public class SupplierService
    {
        private readonly SupplierRepo _supplierRepo;
        public SupplierService(SupplierRepo supplierRepo)
        {
            _supplierRepo = supplierRepo;
        }
        public string CreateSupplier(Supplier supplier)
        {
            return _supplierRepo.CreateSupplier(supplier);
        }
        public string DeleteSupplierById(int id)
        {
            return _supplierRepo.DeleteSupplierById(id);
        }
        public List<Supplier> GetAllSupplier()
        {
            return _supplierRepo.GetAllSupplier();
        }
        public Supplier GetSupplierById(int id)
        {
            return _supplierRepo.GetSupplierById(id);
        }
        public string UpdateSupplier(Supplier supplier)
        {
            return _supplierRepo.UpdateSupplier(supplier);
        }
    }
}