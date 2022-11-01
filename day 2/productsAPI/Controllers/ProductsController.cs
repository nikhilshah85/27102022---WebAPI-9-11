using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsAPI.Models;
namespace productsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products pObj = new Products(); //we should use DI - dependency injection here

        [HttpGet]
        [Route("plist")]
        public IActionResult GetAllProducts()
        {
            return Ok(pObj.GetAllproducts());
        }
        [HttpGet]
        [Route("plist/search/{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                return Ok(pObj.GetProductById(id));
            }
            catch(Exception es)
            {
                return NotFound(es.Message);
            }
        }
        [HttpGet]
        [Route("plist/availabe/{yesNo}")]
        public IActionResult GetProductInStock(bool yesNo)
        {
            return Ok(pObj.GetAvailableProduct(yesNo));
        }

        [HttpPost]
        [Route("plist/add")]
        public IActionResult AddProduct([FromBody]Products newProduct)
        {
            return Created("",pObj.AddProduct(newProduct));
        }

        [HttpDelete]
        [Route("plist/delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                return Accepted(pObj.DeleteProduct(id));
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }
      
        [HttpPut]
        [Route("plist/edit")]
        public IActionResult EditResult(Products changes)
        {
            try
            {
                return Accepted(pObj.EditProduct(changes));
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }
    }
}
