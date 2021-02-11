using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4;

namespace WebApplication3.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult studentreg()
        {
            return View();
        }
        public ActionResult companyreg()
        {
            return View();
        }
        public ActionResult student(stud ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                std.sp_student(ob.id, ob.name, ob.age, ob.qualification, ob.passoutyear, ob.email, ob.username, ob.password);
                ob.msg = ("successfully registered");
                ModelState.Clear();


                return View("studentreg", ob);
            }
            return View("studentreg", ob);
        }



        public ActionResult company(comp ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                std.sp_company(ob.id, ob.compname, ob.address, ob.phone, ob.email, ob.password);
                ob.msg = ("successfully registered");
                ModelState.Clear();


                return View("companyreg", ob);
            }
            return View("companyreg", ob);
        }



    }
}
    