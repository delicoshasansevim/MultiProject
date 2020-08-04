using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult about()
        {
            return View();
        }



        public Int32 SumIt(Int32 a, Int32 b) 
        {
            Int32 temp = a + b;
            return temp;
        }


    } // endof class
} // end of amespace
