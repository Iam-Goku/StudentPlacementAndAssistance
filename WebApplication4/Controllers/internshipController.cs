using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4;

namespace WebApplication3.cont.Controllers
{
    public class internshipController : Controller
    {
        // GET: internship
        public ActionResult interns()
        {
            return View();
        }
        public ActionResult studinterns(intern ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                std.sp_intern(ob.id, ob.amount, ob.duration, ob.internshipname,ob.contactnumber,ob.email);
                ob.msg = ("successfully added");
                ModelState.Clear();
                return View("interns", ob);
            }
            return View("interns", ob);
        }
   
        }
    }