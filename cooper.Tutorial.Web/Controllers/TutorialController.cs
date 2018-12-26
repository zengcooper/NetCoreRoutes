using System;
using Microsoft.AspNetCore.Mvc;

namespace cooper.Tutorial.Web.Controllers
{
    public class TutorialController : Controller
    {

        public IActionResult Index()
        {
            return Content("ASP.NET Core Tutorial by cooper from cooper.io");
        }

        public IActionResult Welcome(string name, int age)
        {
            return Content($"Welcome {name}(age:{age}) !");
        }
    }
}
