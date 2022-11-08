using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repositoryPattern_demo.Model.Repository;

namespace repositoryPattern_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        IProductRepository _products;

        public ProductsController(IProductRepository _productRef)
        {
            _products = _productRef;
        }


        [HttpGet]
        [Route("plist")]
        public IActionResult GetAllProducts()
        {
            return Ok(_products.GetAllProducts());
        }
        [HttpGet]
        [Route("plist/{pId}")]
        public IActionResult GetProductById(int pId)
        {
            return Ok(_products.GetProductById(pId));
        }
        [HttpPost]
        [Route("plist/add")]
        public IActionResult AddProduct(ProductsModel pObj)
        {
            return Created("",_products.AddProduct(pObj));
        }
       







    }
}
