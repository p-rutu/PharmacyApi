using Microsoft.EntityFrameworkCore;

using PharmacyUpdated.Models;
using PharmacyUpdated.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharamcy.Repositere
{
    public class SupplierRepo : ISuppllier
    {
        private readonly PharmacyProjectContext _context;
        public SupplierRepo(PharmacyProjectContext context)
        {
            _context = context;
        }



        #region CreateSupplier
        public string CreateSupplier(Supplier supplier)
        {
            string stCode = string.Empty;
            try
            {
                if(supplier!= null)
                {
                    _context.Suppliers.Add(supplier);
                    _context.SaveChanges();
                    stCode = "200";
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return stCode;
        }
        #endregion

        #region DeleteSupplierbyID
        public string DeleteSupplierById(int id)
        {
            string Result = string.Empty;
            Supplier delete;

            try
            {
                delete = _context.Suppliers.Find(id);

                if (delete != null)
                {
                    _context.Suppliers.Remove(delete);
                    _context.SaveChanges();
                    Result = "200";
                }
            }
            catch (Exception ex)
            {
                Result = "400";
            }
            finally
            {
                delete = null;
            }
            return Result;
        }
        #endregion

        #region GetAllSuppliers
        public List<Supplier> GetAllSupplier()
        {
            List<Supplier> suppliers = null;
            try
            {
                suppliers = _context.Suppliers.ToList();
            }
            catch (Exception)
            {

            }
            return suppliers;

        }
        #endregion

        #region GetSupplierbyId
        public Supplier GetSupplierById(int id)
        {
            Supplier supplier = null;
            try
            {
                supplier = _context.Suppliers.Find(id);
            }
            catch (Exception ex)
            {

            }
            return supplier;
        }
        #endregion

        #region UpdateSupplier
        public string UpdateSupplier(Supplier supplier)
        {
            string stCode = string.Empty;

            try
            {

                _context.Entry(supplier).State = EntityState.Modified;
                _context.SaveChanges();
                stCode = "200";

            }
            catch (Exception ex)
            {
                stCode = "400";
            }
            return stCode;
        }
        #endregion
    }

}