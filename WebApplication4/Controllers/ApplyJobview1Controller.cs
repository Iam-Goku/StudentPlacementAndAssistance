using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class ApplyJobview1Controller : Controller
    {
        // GET: ApplyJobview1
        public ActionResult Jobapply()
        {
            return View();
        }
        public ActionResult Applyjob1(studlog ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                ObjectParameter obj = new ObjectParameter("status", typeof(int));
                std.sp_loginstu(ob.username, ob.password, obj);
                int value = Convert.ToInt32(obj.Value);
                if (value == 1)
                {
                    std.sp_appljob1(ob.username, ob.password, obj);
                    ob = new studlog();
                    ModelState.Clear(); 
                    
                    ob.msg = "Job Apply Succesfull";
                    return View("Applyjob1", ob);
                }
                else
                {
                    ob = new studlog();
                    ModelState.Clear();
                    ob.msg = "Please Register first";
                    return View("Applyjob1", ob);
                }

            }
            else
            {
                return View("Applyjob1", ob);

            }
        }
    }
}