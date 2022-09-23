using CRUD_Repository_Ajax.Repositories;
using DemoJWTSwaggerData.Context;
using DemoJWTSwaggerData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoJWTSwaggerData.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class SalesMasterController : ControllerBase
   {
      private ApplicationDBContext _context;
      private ISalesRepository _repository;
      public SalesMasterController(ApplicationDBContext context, ISalesRepository repository)
      {
         _context = context;
         this._repository = repository;
      }
      [HttpPost]
      //[ValidateAntiForgeryToken]
      public async Task<IActionResult> save(SalesMaster entity)
      {
         var result = _repository.Save(entity);
         //return Json(new { data = result });
         if (result > 0)
         {
            return Created("",entity);
         }
         else
         {
            return Problem("",  "problem");
         }


      }
   }
}
