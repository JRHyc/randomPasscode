using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace randomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")] 
        public IActionResult index()
        {
            return View();
        }
    }
}