using Microsoft.AspNetCore.Mvc;

namespace JRDemo.Controllers;

[Route("[controller]")]
public class HelloWorldController : Controller
{
	[HttpGet("/hello")]
	public IActionResult GetHelloWorld()
	{
		return Ok("Hello, World Patrick!");
	}
}


// [ApiController]
//     [Route("[controller]")]
//     public class HelloWorldController : ControllerBase
//     {
//         [HttpGet("hello")]
//         public IActionResult GetHelloWorld()
//         {
//             return Ok("Hello, World!");
//         }
//     }