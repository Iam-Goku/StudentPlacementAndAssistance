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
    public class passwordController : Controller
    {
        // GET: password
        public ActionResult changeload()
        {
            return View();
        }
        public ActionResult changeload1()
        {
            return View();
        }
        public ActionResult changclick(pwd pw)
        {
            if (ModelState.IsValid)
            {
                registrationEntities ob = new registrationEntities();
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                ob.sp_changepwd(pw.oldpwd, pw.newpwd, Session["log"].ToString(), op);
                int i = Convert.ToInt32(op.Value);
                if (i == 1)
                {
                    pw.result = "password changed";
                    return View("changeload", pw);
                }
                else
                {
                    pw.result = "invalid password";
                    return View("changeload", pw);
                }
            }
            return View("changload", pw);

        }
    public ActionResult changclick1(companypwd pw)
    {
        if (ModelState.IsValid)
        {
            registrationEntities ob = new registrationEntities();
            ObjectParameter op = new ObjectParameter("status", typeof(int));
            ob.sp_comppwd(pw.oldpwd, pw.newpwd, Session["log"].ToString(), op);
            int i = Convert.ToInt32(op.Value);
            if (i == 1)
            {
                pw.result = "password changed";
                return View("changeload1", pw);
            }
            else
            {
                pw.result = "invalid password";
                return View("changeload1", pw);
            }
        }
        return View("changload1", pw);

    }
}
}
