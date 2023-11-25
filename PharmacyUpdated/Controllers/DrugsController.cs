using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    public class DrugController : ControllerBase
    {
       
        private readonly DrugService _drug;

        public DrugController(DrugService drugService)
        {
            _drug = drugService;
            
        }

        // GET: api/Drug
        [HttpGet]
      
        public List<Drug> GetDrugs()
        {

            return _drug.GetAllDrugsAsync();
        }

        // GET: api/Drug/5
        [HttpGet("{id}")]
        public IActionResult GetDrug(int id)
        {
            return Ok(_drug.GetDrugById(id));

        }

        // PUT: api/Drug/5
 
        [HttpPut]
        public IActionResult PutDrug( Drug drug)
        {
            return Ok(_drug.UpdateDrug(drug));

        }
        // POST: api/Drug

        [HttpPost]
        public IActionResult PostDrug(Drug drug)
        {


            return Ok(_drug.CreateDrug(drug));
        }

        // DELETE: api/Drug/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDrug(int id)
        {
            return Ok(_drug.DeleteDrugById(id));


        }


    }

   



}