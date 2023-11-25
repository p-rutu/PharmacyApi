using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyUpdated.Models;
using PharmacyUpdated.services;
using System.Collections.Generic;

namespace PharmacyUpdated.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinalDbController : ControllerBase
    {
        private readonly FinalDbService _order;

        public FinalDbController(FinalDbService order)
        {
            _order = order;
        }

        // GET: api/OrderDetail
        [HttpGet]
        public List<FinalDb> GetOrderDetails()
        {
            return _order.GetAllOrderDetail();
        }



        // GET: api/OrderDetail/5
        [HttpGet("{id}")]
        public List<FinalDb> GetOrderDetail(int id)
        {

            return _order.GetOrderDetailById(id);
        }

        // PUT: api/OrderDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PutOrderDetail")]
        public IActionResult PutOrderDetail(FinalDb orderDetail)
        {

            return Ok(_order.UpdateOrderDetail(orderDetail));
        }

        // POST: api/OrderDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostOrderDetail(FinalDb orderDetail)
        {
            return Ok(_order.CreateOrderDetail(orderDetail));
        }

        // DELETE: api/OrderDetail/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {


            return Ok(_order.DeleteOrderDetailById(id));
        }
    }
}
