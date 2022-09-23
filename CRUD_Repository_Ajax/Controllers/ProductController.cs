using CRUD_Repository_Ajax.Models;
using CRUD_Repository_Ajax.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD_Repository_Ajax.Controllers
{
    public class ProductController : Controller
    {
        private DbInv _context;
        private IProductRepository _repository;
        public ProductController(DbInv context, IProductRepository repository)
        {
            _context = context;
           this._repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult getProducts()
        {
            //List<SelectListItem> products = (from p in this._context.Products
            //                                 select new SelectListItem
            //                                 {
            //                                     Value = p.Id.ToString(),
            //                                     Text =p.ProductName
            //                                 }).ToList();



           var prd= _context.Products.OrderBy(p => p.ProductName)
                                            .Select(s=>new SelectListItem
                                                { Text=s.ProductName,
                                                Value=s.Id.ToString()
                                                 
                                                }).ToList();


            //return Json(new  { Data = products }, new Newtonsoft.Json.JsonSerializerSettings());
            return Json(prd);
        }
        public JsonResult GetUnitPriceByPid(int pid)
        {
             var prd = _context.Products.Where(p=>p.Id==pid).Select(p=>p.UnitPrice).FirstOrDefault();
            return Json(prd);
        }
        public IActionResult GetAll()
      {
         return Json(new { data = _repository.GetAll(), isSuccess = true });
      }
      public Product GetByID(int id)
      {
         return _repository.GetByID(id);
      }
      [HttpPost]
      public JsonResult Create(Product entity)
      {
         var result = _repository.Save(entity);
         //return Json(new { data = result });
         if (result > 0)
         {
            return Json(new { isSuccess = true, messsage = "Successfully saved" });
         }
         else
         {
            return Json(new { isSuccess = false, messsage = "problem" });
         }
      }
      public int Delete(int id)
      {
         return _repository.Delete(id);
      }
      public int Edit(Product entity)
      {
         return _repository.Update(entity);
      }

   }
}
