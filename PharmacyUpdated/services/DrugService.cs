
using pharamcy.Repositere;
using PharmacyUpdated.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pharamcy.Services
{
    public class DrugService
    {
        private readonly DrugRepo _drugRepo;
        public DrugService(DrugRepo drugRepo)
        {
            _drugRepo = drugRepo;
        }
        public string CreateDrug(Drug drug)
        {
            return _drugRepo.CreateDrug(drug);
        }
        public string DeleteDrugById(int id)
        {
            return _drugRepo.DeleteDrugById(id);
        }
        public List<Drug> GetAllDrugsAsync()
        {
            return _drugRepo.GetAllDrugsAsync();
        }
        public Drug GetDrugById(int id)
        {
            return _drugRepo.GetDrugById(id);
        }
        public string UpdateDrug( Drug drug)
        {
            return (_drugRepo.UpdateDrug(drug));
        }
    }
}