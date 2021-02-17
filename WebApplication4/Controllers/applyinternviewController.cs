using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication4;

namespace WebApplication3.cont.Controllers
{
    public class applyinternviewController : Controller


    {
      
        public ActionResult Button()
        {

            return View();

        }


        [HttpPost]
        public ActionResult Button(internviewapply ob)
        {
            if (ModelState.IsValid)
            {
                registrationEntities std = new registrationEntities();
                std.sp_appintern(ob.id, ob.name, ob.place, ob.qulificaiton);
                ob.msg = "succesfully registered";
                ModelState.Clear();


            }
            else
            {

                ob.msg = "Please enter a valid Data";

            }
            return View(ob);

        }
    
        public ActionResult internview()
        {

           
            registrationEntities std = new registrationEntities();
            var no =std.sp_viewintern().ToList();
            return View(no.ToList());

           

        }



  
     

    }
}