using PharmacyUpdated.Models;
using System.Collections.Generic;

namespace PharmacyUpdated.Repository
{
    
        public interface IFinalDb
        {
            public List<FinalDb> GetAllOrderDetail();
            public List<FinalDb> GetOrderDetailById(int id);
            public string UpdateOrderDetail(FinalDb orderDetail);
            public FinalDb CreateOrderDetail(FinalDb orderDetail);
            public string DeleteOrderDetailById(int id);
        }
    
}
