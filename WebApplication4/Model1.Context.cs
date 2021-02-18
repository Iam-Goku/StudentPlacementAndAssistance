﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class registrationEntities : DbContext
    {
        public registrationEntities()
            : base("name=registrationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<applyintern> applyinterns { get; set; }
        public virtual DbSet<companyy> companyies { get; set; }
        public virtual DbSet<internship> internships { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<jobapply> jobapplies { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<applyjob1> applyjob1 { get; set; }
    
        public virtual int sp_admin(Nullable<int> id, string name, string password)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_admin", idParameter, nameParameter, passwordParameter);
        }
    
        public virtual int sp_appintern(Nullable<int> id, string name, string place, string qulification)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var placeParameter = place != null ?
                new ObjectParameter("place", place) :
                new ObjectParameter("place", typeof(string));
    
            var qulificationParameter = qulification != null ?
                new ObjectParameter("qulification", qulification) :
                new ObjectParameter("qulification", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_appintern", idParameter, nameParameter, placeParameter, qulificationParameter);
        }
    
        public virtual int sp_appjob(Nullable<int> id, string date)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var dateParameter = date != null ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_appjob", idParameter, dateParameter);
        }
    
        public virtual int sp_changepwd(string oldpwd, string newpwd, string uname, ObjectParameter status)
        {
            var oldpwdParameter = oldpwd != null ?
                new ObjectParameter("oldpwd", oldpwd) :
                new ObjectParameter("oldpwd", typeof(string));
    
            var newpwdParameter = newpwd != null ?
                new ObjectParameter("newpwd", newpwd) :
                new ObjectParameter("newpwd", typeof(string));
    
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_changepwd", oldpwdParameter, newpwdParameter, unameParameter, status);
        }
    
        public virtual int sp_company(Nullable<int> id, string companyname, string address, string phone, string email, string password)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var companynameParameter = companyname != null ?
                new ObjectParameter("companyname", companyname) :
                new ObjectParameter("companyname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_company", idParameter, companynameParameter, addressParameter, phoneParameter, emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<sp_compprof_Result> sp_compprof(string companyname)
        {
            var companynameParameter = companyname != null ?
                new ObjectParameter("companyname", companyname) :
                new ObjectParameter("companyname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_compprof_Result>("sp_compprof", companynameParameter);
        }
    
        public virtual int sp_comppwd(string oldpwd, string newpwd, string companyname, ObjectParameter status)
        {
            var oldpwdParameter = oldpwd != null ?
                new ObjectParameter("oldpwd", oldpwd) :
                new ObjectParameter("oldpwd", typeof(string));
    
            var newpwdParameter = newpwd != null ?
                new ObjectParameter("newpwd", newpwd) :
                new ObjectParameter("newpwd", typeof(string));
    
            var companynameParameter = companyname != null ?
                new ObjectParameter("companyname", companyname) :
                new ObjectParameter("companyname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_comppwd", oldpwdParameter, newpwdParameter, companynameParameter, status);
        }
    
        public virtual int sp_intern(Nullable<int> id, string amount, string duration, string internshipname, string contactnumber, string email)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var amountParameter = amount != null ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(string));
    
            var durationParameter = duration != null ?
                new ObjectParameter("duration", duration) :
                new ObjectParameter("duration", typeof(string));
    
            var internshipnameParameter = internshipname != null ?
                new ObjectParameter("internshipname", internshipname) :
                new ObjectParameter("internshipname", typeof(string));
    
            var contactnumberParameter = contactnumber != null ?
                new ObjectParameter("contactnumber", contactnumber) :
                new ObjectParameter("contactnumber", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_intern", idParameter, amountParameter, durationParameter, internshipnameParameter, contactnumberParameter, emailParameter);
        }
    
        public virtual int sp_job(Nullable<int> id, string jobtitle, Nullable<int> experiance, string vaccancies, string contactnumber, string email)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var jobtitleParameter = jobtitle != null ?
                new ObjectParameter("jobtitle", jobtitle) :
                new ObjectParameter("jobtitle", typeof(string));
    
            var experianceParameter = experiance.HasValue ?
                new ObjectParameter("experiance", experiance) :
                new ObjectParameter("experiance", typeof(int));
    
            var vaccanciesParameter = vaccancies != null ?
                new ObjectParameter("vaccancies", vaccancies) :
                new ObjectParameter("vaccancies", typeof(string));
    
            var contactnumberParameter = contactnumber != null ?
                new ObjectParameter("contactnumber", contactnumber) :
                new ObjectParameter("contactnumber", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_job", idParameter, jobtitleParameter, experianceParameter, vaccanciesParameter, contactnumberParameter, emailParameter);
        }
    
        public virtual int sp_loginadm(string name, string password, ObjectParameter status)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_loginadm", nameParameter, passwordParameter, status);
        }
    
        public virtual int sp_loginadmin(string name, string password, Nullable<int> status)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_loginadmin", nameParameter, passwordParameter, statusParameter);
        }
    
        public virtual int sp_logincom(string companyname, string password, ObjectParameter status)
        {
            var companynameParameter = companyname != null ?
                new ObjectParameter("companyname", companyname) :
                new ObjectParameter("companyname", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_logincom", companynameParameter, passwordParameter, status);
        }
    
        public virtual int sp_loginstu(string username, string password, ObjectParameter status)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_loginstu", usernameParameter, passwordParameter, status);
        }
    
        public virtual ObjectResult<sp_profile_Result> sp_profile(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_profile_Result>("sp_profile", usernameParameter);
        }
    
        public virtual int sp_student(Nullable<int> id, string name, Nullable<int> age, string qualification, string passoutyear, string email, string username, string password)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var qualificationParameter = qualification != null ?
                new ObjectParameter("qualification", qualification) :
                new ObjectParameter("qualification", typeof(string));
    
            var passoutyearParameter = passoutyear != null ?
                new ObjectParameter("passoutyear", passoutyear) :
                new ObjectParameter("passoutyear", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_student", idParameter, nameParameter, ageParameter, qualificationParameter, passoutyearParameter, emailParameter, usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<sp_viewintern_Result> sp_viewintern()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_viewintern_Result>("sp_viewintern");
        }
    
        public virtual ObjectResult<sp_viewjob_Result> sp_viewjob()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_viewjob_Result>("sp_viewjob");
        }
    
        public virtual int sp_appljob1(string username, string password, ObjectParameter status)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_appljob1", usernameParameter, passwordParameter, status);
        }
    
        public virtual ObjectResult<string> sp_jobappview()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_jobappview");
        }
    
        public virtual ObjectResult<sp_viewappjob_Result> sp_viewappjob()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_viewappjob_Result>("sp_viewappjob");
        }
    
        public virtual ObjectResult<sp_jobapply_Result> sp_jobapply(string name, string password)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_jobapply_Result>("sp_jobapply", nameParameter, passwordParameter);
        }
    
        public virtual int sp_jobapp(Nullable<int> id, string name, string place, string qualification)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var placeParameter = place != null ?
                new ObjectParameter("place", place) :
                new ObjectParameter("place", typeof(string));
    
            var qualificationParameter = qualification != null ?
                new ObjectParameter("qualification", qualification) :
                new ObjectParameter("qualification", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_jobapp", idParameter, nameParameter, placeParameter, qualificationParameter);
        }

        public System.Data.Entity.DbSet<WebApplication4.Models.jobapp> jobapps { get; set; }
    }
}
