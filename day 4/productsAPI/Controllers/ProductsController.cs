using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsAPI.Models;
namespace productsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        Products pObj = new Products();

        [HttpGet]
        [Route("plist")]
        public IActionResult GetProducts()
        {
            return Ok(pObj.GetAllProducts());

        }
    }
}
