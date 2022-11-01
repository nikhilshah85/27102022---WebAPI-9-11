using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {

        [HttpGet]
        [Route("greet")]
        public IActionResult Greetings()
        {
            //we will return standard HTTP Status Code
            return Ok("Hello and Welcome to WebAPI");
        }
        [HttpGet]
        [Route("greet/guestName")]
        public IActionResult Greetings(string guestName)
        {
            return Ok("Hello and welcome " + guestName);
        }
        [HttpGet]
        [Route("add/{num1}/{num2}")]
        public IActionResult AddNumbers(int num1, int num2)
        {

            if (num1 == 0 || num2 ==0)
            {
                return Ok("Please enter only positve numbers");

            }
            if (num1 < num2)
            {
                return Ok("First Number has to be greater than second number");
            }


            int addresult = num1 + num2;
            return Ok(addresult);
        }

        static List<string> pList = new List<string>()
        {
            "Pepsi", "IPhone","Nike","Air-pods","Dell","Surface Pro","Jeep Compass","Appy Fizz","Maggie Noodles"
        };

        [HttpGet]
        [Route("plist")]
        public IActionResult ProductList()
        {
            return Ok(pList);
        }

        [HttpGet]
        [Route("plist/{index}")]
        public IActionResult SearchProduct(int index)
        {
            if (index > pList.Count)
            {
                return NotFound("Product Not found in list");
            }
            if (index < 0)
            {
                return Ok("please provide only positive value");
            }
            return Ok(pList[index]);
        }
    }
}
