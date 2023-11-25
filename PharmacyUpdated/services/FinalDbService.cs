using PharmacyUpdated.Models;
using PharmacyUpdated.Repository;
using System.Collections.Generic;

namespace PharmacyUpdated.services
{
    public class FinalDbService
    {
        private readonly FinalDbRepo _order;
        public FinalDbService(FinalDbRepo order)
        {
            _order = order;
        }
        public FinalDb CreateOrderDetail(FinalDb orderDetail)
        {
            return _order.CreateOrderDetail(orderDetail);
        }
        public string DeleteOrderDetailById(int id)
        {
            return _order.DeleteOrderDetailById(id);
        }
        public List<FinalDb> GetAllOrderDetail()
        {
            return _order.GetAllOrderDetail();
        }
        public List<FinalDb> GetOrderDetailById(int id)
        {
            return _order.GetOrderDetailById(id);
        }
        public string UpdateOrderDetail(FinalDb orderDetail)
        {
            return _order.UpdateOrderDetail(orderDetail);
        }
    }
}
