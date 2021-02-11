using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4;

namespace WebApplication3.cont.Controllers
{
    public class profileController : Controller
    {
        // GET: profile
        public ActionResult profileload()
        {
            registrationEntities std = new registrationEntities();
            var getdata = std.sp_profile(Session["log"].ToString()).FirstOrDefault();

            return View(new profileClass1
            {
                name = getdata.name,
                age = Convert.ToInt32(getdata.age),
                qualification = getdata.qualification,
                passoutyear = getdata.passoutyear,
                email = getdata.email
            }
 );
        }
        public ActionResult companyprofile()
        {
            registrationEntities std = new registrationEntities();
            var getdata = std.sp_compprof(Session["log"].ToString()).FirstOrDefault();

            return View(new companyprof
            {
                companyname = getdata.companyname,
                address = getdata.address,
                phone = getdata.phone,
                email = getdata.email
            }
 );

        }
    


    }
    }
