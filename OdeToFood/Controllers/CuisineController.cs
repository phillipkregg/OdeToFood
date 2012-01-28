using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Infrastructure;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]

    public class CuisineController : Controller
    {

        [HttpGet]
        
        public ActionResult Search(string name = "*")
        {

            throw new Exception("oops!");

            //if (name == "*")
            //{
            //    return Json(new { cuisineName = name }, JsonRequestBehavior.AllowGet);
            //}

            name = Server.HtmlEncode(name);
            return Content(name);
        }

    }
}
