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
            var no = std.sp_viewappjob();
          
            return View(no.ToList());
        }
    }
}