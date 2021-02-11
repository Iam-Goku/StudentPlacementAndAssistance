using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class applyjobviewController : Controller
    {
        // GET: applyjobview
        public ActionResult jobview()
        {
            registrationEntities std = new registrationEntities();
            var getdata = std.sp_viewjob().ToList();
            ViewBag.jobdetails = getdata;
            return View();

        }
    }
}