using CRUD_Repository_Ajax.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CRUD_Repository_Ajax.Controllers
{
   public class MasterController : Controller
   {
      public IActionResult Index()
      {
         List<SalesMasterVM> sales = new List<SalesMasterVM>();
         string apiUrl = "https://localhost:7173/api/SalesMaster";

         HttpClient client = new HttpClient();
         //HttpResponseMessage response = client.GetAsync(apiUrl + string.Format("/GetCustomers?name={0}", name)).Result;
         HttpResponseMessage response = client.GetAsync(apiUrl).Result;
         if (response.IsSuccessStatusCode)
         {
            sales = JsonConvert.DeserializeObject<List<SalesMasterVM>>(response.Content.ReadAsStringAsync().Result);
         }
         return View(sales);
      }
   }
}
