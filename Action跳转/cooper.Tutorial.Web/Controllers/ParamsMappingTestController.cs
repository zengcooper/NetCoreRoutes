using System;
using System.Collections.Generic;
using cooper.Tutorial.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace cooper.Tutorial.Web.Controllers
{
    public class ParamsMappingTestController : Controller
    {
        public IActionResult GetId(int id)
        {
            return Content($"Action params mapping test by cooper.io, id:{id}");
        }

        public IActionResult GetArray(string[] id)
        {
            var message = "Action params mapping test by cooper.io,id:";
            if (id != null)
            {
                message += string.Join(",", id);
            }
            return Content(message);
        }

        public IActionResult GetPerson(Person person)
        {
            return Json(new { Message = "Action params mapping test by cooper.io", Data = person });
        }

        public IActionResult GetPersonList(List<Person> person)
        {
            return Json(new { Message = "Action params mapping test by cooper.io", Data = person });
        }

        public IActionResult GetPersonJson([FromBody]Person person)
        {
            return Json(new { Message = "Action params mapping test by cooper.io", Data = person });
        }

        public IActionResult GetByHand()
        {
            return Json(new
            {
                Id = RouteData.Values["id"],
                Name = Request.Query["name"]
            });
        }

    }
}
