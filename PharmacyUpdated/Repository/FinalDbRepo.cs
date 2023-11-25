using Microsoft.EntityFrameworkCore;
using PharmacyUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyUpdated.Repository
{
    public class FinalDbRepo:IFinalDb
    {
        private readonly PharmacyProjectContext _context;
        public FinalDbRepo(PharmacyProjectContext context)
        {
            _context = context;
        }
        public FinalDb CreateOrderDetail(FinalDb order)
        {
            string stcode = string.Empty;
            try
            {
                _context.FinalDbs.Add(order);
                _context.SaveChanges();
                stcode = "200";
            }
            catch (Exception e)
            {
                stcode = "400";
            }

            return order;

        }

        public string DeleteOrderDetailById(int orderid)
        {
            string Result = string.Empty;
            FinalDb orderDetail = null;
            try
            {
                orderDetail = _context.FinalDbs.Find(orderid);
                if (orderDetail != null)
                {
                    _context.FinalDbs.Remove(orderDetail);
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

        public List<FinalDb> GetAllOrderDetail()
        {
            List<FinalDb> result = null;
            try
            {
                result = _context.FinalDbs.ToList();
            }
            catch (Exception)
            {

            }
            return result;
        }

        public List<FinalDb> GetOrderDetailById(int id)
        {
            List<FinalDb> result = null;
            try
            {

                result=_context.FinalDbs.Where(e=>e.UserId==id).ToList();
            }
            catch (Exception)
            {

            }
            return result;
        }

        public string UpdateOrderDetail(FinalDb orderDetail)
        {
            string Result = string.Empty;

            try
            {
                _context.Entry(orderDetail).State = EntityState.Modified;
                _context.SaveChanges();
                Result = "200";


            }
            catch (Exception e)
            {
                Result = "400";
            }
            return Result;
        }
    }
}
