using PharmacyUpdated.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyUpdated.Repository
{
    public interface IDrug
    {

        public List<Drug> GetAllDrugsAsync();
        public Drug GetDrugById(int id);
        public string UpdateDrug( Drug drug);
        public string CreateDrug(Drug drug);
        public string DeleteDrugById(int id);
    }
}
