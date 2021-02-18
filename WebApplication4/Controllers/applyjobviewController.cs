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
        public ActionResult Jobbtn()
        {

            return View();

        }


        [HttpPost]
        public ActionResult Jobbtn(jobapp ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                std.sp_jobapp(ob.id, ob.name, ob.place, ob.qualification);
                ob.msg = "succesfully registered";            
                ModelState.Clear();  


            }
            else
            {

                ob.msg = "Please enter a valid Data";

            }
            return View(ob);

        }
        public ActionResult jobview()
        {
            registrationEntities std = new registrationEntities();
            var getdata = std.sp_viewjob().ToList();
            ViewBag.jobdetails = getdata;
            return View();

        }
    }
}