using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4;

namespace WebApplication3.cont.Controllers
{
    public class jobController : Controller
    {
        // GET: job
        public ActionResult compjob()
        {
            return View();
        }
        public ActionResult job(jobs ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                std.sp_job(ob.id, ob.jobtitle, ob.experiance, ob.vaccancies, ob.contactnumber, ob.email);
                ob.msg = ("successfully added");
                ModelState.Clear();


                return View("compjob", ob);
            }
            return View("compjob", ob);
        }

            
        }
    }
