using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Lab02.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "this is my default action";
        }
        public IActionResult Welcome(string name, int numTimes=1)
        {

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
