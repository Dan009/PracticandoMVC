using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index() {
            return View();
            
        
        }

        //
        // GET: /HelloWorld/Welcome

        public ActionResult Welcome(string name = "", int numTimes = 1)
        {
            name = (name == "") ? "D: i dont know you :c !!!" : name;
            ViewBag.Message = "Hello "+name;
            ViewBag.NumTimes = numTimes;

            return View();

        }

       

    }
}
