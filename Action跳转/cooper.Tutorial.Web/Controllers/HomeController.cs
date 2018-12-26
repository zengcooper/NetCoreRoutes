using System;
using Microsoft.AspNetCore.Mvc;

namespace cooper.Tutorial.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World ！ -cooper.io");
        }

        public string Test()
        {
            return "test";
        }

        public void DoSomething()
        {
            //DoSomething
        }

        [NonAction]
        public void LogicMethod(){

        }

        public IActionResult Time()
        {
            //将当前服务器时间放入ViewBag中
            ViewBag.ServerTime = DateTime.Now;
            return View("Time");
        }
    }
}
