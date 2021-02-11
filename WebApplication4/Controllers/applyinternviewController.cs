using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4;

namespace WebApplication3.cont.Controllers
{
    public class applyinternviewController : Controller
    {
        // GET: applyinternview
        public ActionResult internview()
        {
          
            
            registrationEntities std = new registrationEntities();
            var no =std.sp_viewintern().ToList();
            return View(no.ToList());



        }

    }
}