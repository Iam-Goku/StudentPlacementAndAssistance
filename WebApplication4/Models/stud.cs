using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{

    public class stud
    {
        [Required(ErrorMessage = "Enter id")]
        public int id { get; set; }
        [Required(ErrorMessage = "Enter the name")]

        public string name { get; set; }
        [Range(18, 50, ErrorMessage = "Range between 18 and 50")]

        public int age { get; set; }
        [Required(ErrorMessage = "Enter qualification")]
        public string qualification { get; set; }
      
        [Required(ErrorMessage = "Enter passoutyear")]
        public string passoutyear { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "invalidEmailAddress")]
        public string email { get; set; }
        [Required(ErrorMessage = "username is required")]

        public string username { get; set; }
        [Required(ErrorMessage = "pwd is required")]

        public string password { get; set; }
        //[Compare("pwd",ErrorMessage ="pwd and cpwd do not match")]
       
        public string msg { get; set; }




    }
}