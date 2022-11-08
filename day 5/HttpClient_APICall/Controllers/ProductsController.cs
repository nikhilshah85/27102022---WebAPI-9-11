using Microsoft.AspNetCore.Mvc;
using HttpClient_APICall.Models;
namespace HttpClient_APICall.Controllers
{
    public class ProductsController : Controller
    {
      
        public IActionResult DisplayProducts()
        {
            ProductsData pObj = new ProductsData();
            ViewBag.data = pObj.GetProductData();
            return View();
        }

      


    }
}
