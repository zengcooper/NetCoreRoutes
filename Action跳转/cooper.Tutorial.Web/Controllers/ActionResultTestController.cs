using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace cooper.Tutorial.Web.Controllers
{
    public class ActionResultTestController : Controller
    {
        public IActionResult ContentTest()
        {
            return Content("ContentResult Test by cooper.io");
        }

        public IActionResult JsonTest()
        {
            return Json(new { Message = "JsonResult Test", Author = "cooper.io" });
        }

        public IActionResult FileTest()
        {
            var bytes = Encoding.Default.GetBytes("FileResult Test by cooper.io");
            return File(bytes, "application/text", "filetest.txt");
        }

        public IActionResult RedirectTest()
        {
            return Redirect("https://cooper.io");
        }

        public IActionResult RedirectToActionTest()
        {
            return RedirectToAction("jsontest");
        }

        public IActionResult RedirectToRouteTest()
        {
            return RedirectToRoute("Default", new { Controller = "home", Action = "index" });
        }
    }
}
