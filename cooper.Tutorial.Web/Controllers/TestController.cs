using System;
using Microsoft.AspNetCore.Mvc;

namespace cooper.Tutorial.Web.Controllers
{
    [Route("/test")]
    public class TestController : Controller
    {
        [Route("")]
        [Route("/test/home")]
        public IActionResult Index()
        {
            return Content("ASP.NET Core RouteAttribute test by cooper from cooper.io");
        }

        [Route("servertime")]
        [Route("/t/t")]
        public IActionResult Time(){
            return Content($"ServerTime：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - cooper.io");
        }


        [Route("welcome/{name:name}")]
        public IActionResult Welcome(string name){
            return Content($"Welcome {name} !");
        }
    }
}
