using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using pharamcy.Repositere;
using pharamcy.Services;
using PharmacyUpdated.Models;

namespace pharamcy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly SupplierService _supp;

        public SupplierController(SupplierService supp)
        {
            _supp = supp;
        }

        // GET: api/Supplier
        [HttpGet]

        public List<Supplier> GetAllSuppliers()
        {
            return _supp.GetAllSupplier();
        }

        // GET: api/Supplier/5
        [HttpGet("{id}")]

        public IActionResult GetSuppliersbyId(int id)
        {
            return Ok(_supp.GetSupplierById(id));
        }

        // PUT: api/Supplier/5
        [HttpPut]
        public IActionResult UpdateSupplier(Supplier supplier)
        {
            return Ok(_supp.UpdateSupplier(supplier));
        }

        // POST: api/Supplier
        [HttpPost]
        public IActionResult AddSupplier(Supplier supplier)
        {
            return Ok(_supp.CreateSupplier(supplier));
        }

        // DELETE: api/Supplier/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            var supp = _supp.DeleteSupplierById(id);
            if (supp == null)
            {
                return NotFound();
            }

            return Ok();
        }


    }
}