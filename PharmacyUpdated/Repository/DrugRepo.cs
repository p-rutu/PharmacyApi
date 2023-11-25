using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using PharmacyUpdated.Models;
using PharmacyUpdated.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharamcy.Repositere
{
    public class DrugRepo : IDrug
    {
        private readonly PharmacyProjectContext _context;
        public DrugRepo(PharmacyProjectContext context)
        {
            _context = context;
        }
        #region CreateDrug
        public string CreateDrug(Drug drug)
        {
            string stcode = string.Empty;
            try
            {
                _context.Drugs.Add(drug);
                _context.SaveChanges();
                stcode = "200";
            }
            catch (Exception)
            {
                stcode = "400";
            }

            return stcode;
        }
        #endregion

        #region DeleteDrug
        public string DeleteDrugById(int id)
        {
            string Result = string.Empty;
            Drug drug = null;
            try
            {
                drug = _context.Drugs.Find(id);
                if (drug != null)
                {
                    _context.Drugs.Remove(drug);
                    _context.SaveChanges();
                    Result = "200";
                }
            }
            catch (Exception)
            {
                Result = "400";

            }

            return Result;
        }
        #endregion

        #region GetAllDrugs
        public List<Drug> GetAllDrugsAsync()
        {
            List<Drug> drugs = null;
            try
            {
                drugs = _context.Drugs.ToList();
            }
            catch (Exception)
            {

            }

            return drugs;
        }
        #endregion

        #region GetDrug
        public Drug GetDrugById(int id)
        {
            Drug Result = null;
            try
            {
                Result = _context.Drugs.FirstOrDefault(Drug => Drug.DrugId == id);

            }
            catch (Exception)
            {

            }
            return Result;
        }
        #endregion
        #region UpdateDrug
        public string UpdateDrug(Drug drug)
        {
            string Result = string.Empty;
            try
            {

                _context.Entry(drug).State = EntityState.Modified;
                _context.SaveChanges();
                Result = "200";

            }
            catch (Exception e)
            {
                Result = "400";
            }


            return Result;


        }
        #endregion

    }


}