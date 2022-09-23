
using DemoJWTSwaggerData.Context;
using DemoJWTSwaggerData.Models;

namespace CRUD_Repository_Ajax.Repositories
{
    public class SalesRepository : ISalesRepository
    {
      public ApplicationDBContext _context;

      public SalesRepository(ApplicationDBContext context)

      {
         this._context = context;
      }
      public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesMaster> GetAll()
        {
            throw new NotImplementedException();
        }

        public SalesMaster GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Save(SalesMaster sales)
        {
         bool status = false;
         DateTime dateOrg;
         try
         {
            decimal q = 0.00M;
            decimal P = 0.00M;
            foreach (var item in sales.SalesDetails)
            {
               q += item.Qty;
               P += item.TotalPrice;
            }
            sales.TotalQty = q;
            sales.TotalPrice = P;
            _context.SalesMasters.Add(sales);
            if (_context.SaveChanges() > 0)
            {
               //return Json(new { isSuccess = true, messsage = "Successfully saved" });
               return 1;
            }
         }
         catch (Exception ex)
         {
            //return Json(new { isSuccess = false, messsage = ex.Message });
            return -1;
         }
         //return Json(new { isSuccess = false, messsage = "problem" });
         return 1;
      }

        public int Update(SalesMaster salesMaster)
        {
            throw new NotImplementedException();
        }
    }
}
