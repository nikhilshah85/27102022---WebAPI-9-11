using Microsoft.AspNetCore.Mvc;

namespace ConsumeAPI_Fetch.Controllers
{
    public class ShoppingController : Controller
    {
     
        public IActionResult DisplayProducts()
        {
            return View();
        }
    }
}
