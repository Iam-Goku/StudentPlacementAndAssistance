using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class InternshipapplicationsController : Controller
    {
        // GET: Internshipapplications
        public ActionResult internview()
        {
            registrationEntities std = new registrationEntities();
            var getdata = std.sp_internview().ToList();
            ViewBag.interndetails = getdata;
            return View();
      
        }

    }
}