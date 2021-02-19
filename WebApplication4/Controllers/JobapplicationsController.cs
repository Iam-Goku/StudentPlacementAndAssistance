using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication4.Controllers
{
    public class JobapplicationsController : Controller
    {
        // GET: Jobapplications
   
        public ActionResult jobappview()
        {
                                   
            registrationEntities std = new registrationEntities();
            var getdata = std.sp_viewappjob().ToList();
            ViewBag.appliedjob = getdata;
            return View();
        }
    }
}