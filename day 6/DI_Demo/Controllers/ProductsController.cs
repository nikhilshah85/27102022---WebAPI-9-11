using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        //Products pObj = new Products();  // use DI instead

        Products pObj; //do not createa a new object

        public ProductsController(Products _pObjREF)
        {
            pObj = _pObjREF;
        }








        [HttpGet]
        [Route("plist")]
        public IActionResult GetProducts()
        {
            return Ok(pObj.GetAllProducts());
        }
    }
}
