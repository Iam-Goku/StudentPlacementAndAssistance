using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication4.Controllers
{
    public class viewstuddetailsController : Controller
    {
        // GET: viewstuddetails
        public ActionResult profileload1()
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
    }
}