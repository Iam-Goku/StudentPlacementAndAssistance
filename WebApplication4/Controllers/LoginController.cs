using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4;

namespace WebApplication3.cont.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Loginin()
        {
            return View();
        }
        public ActionResult studentlogin(studlog ob)
        {
                if (ModelState.IsValid)
                {
                    registrationEntities std = new registrationEntities();
                    ObjectParameter obj = new ObjectParameter("status", typeof(int));
                    std.sp_loginstu(ob.username, ob.password,obj);
                    int value = Convert.ToInt32(obj.Value);
                    if (value == 1)
                    {
                        Session["log"] = ob.username;
                        return RedirectToAction("home");
                    }
                    else
                    {
                        ob = new studlog();
                        ModelState.Clear();
                        ob.msg = "login failed";
                        return View("studentlogin", ob);
                    }

                }
            else
            {
                return View("studentlogin", ob);

            }
        }
        public ActionResult companylogin(complog ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                ObjectParameter obj = new ObjectParameter("status", typeof(int));
                std.sp_logincom(ob.companyname, ob.password, obj);
                int value = Convert.ToInt32(obj.Value);
                if (value == 1)
                {
                    Session["log"] = ob.companyname;
                    return RedirectToAction("home1");
                }
                else
                {
                    ob = new complog();
                    ModelState.Clear();
                    ob.msg = "login failed";
                    return View("companylogin", ob);
                }

            }
            else
            {
                return View("companylogin", ob);

            }
        }
        public ActionResult adminlogin(adminlog ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                ObjectParameter obj = new ObjectParameter("status", typeof(int));
                std.sp_loginadm(ob.name, ob.password,obj);
                int value = Convert.ToInt32(obj.Value);
                if (value == 1)
                {
                    Session["log"] = ob.name;
                    return RedirectToAction("home2");
                }
                else
                {
                    ob = new adminlog();
                    ModelState.Clear();
                    ob.msg = "login failed";
                    return View("adminlogin", ob);
                }

            }
            else
            {
                return View("adminlogin", ob);

            }
        }
        public ActionResult home()
        {
            return View();
        }
        public ActionResult home1()
        {
            return View();
        }
        public ActionResult home2()
        {
            return View();
        }
    }

}
