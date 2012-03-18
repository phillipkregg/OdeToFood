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

        // If the user does not specify a 'cuisine' than the '*' will search for everything.
        //  This becomes the default parameter.
        //  This is a compile time constant and a feature of C# 4.
        public ActionResult Search(string name = "*")
        {
            

            throw new Exception("oops!");

            //if (name == "*")
            //{
            //    return Json(new { cuisineName = name }, JsonRequestBehavior.AllowGet);
            //}

            // HTML encoded here because input coming from user - could be dangerous
            // such as a javascript injection
            name = Server.HtmlEncode(name);
            return Content(name);

            
            
        }

    }
}
