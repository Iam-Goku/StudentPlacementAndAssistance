using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class studlog
    {
        [Required(ErrorMessage=" ")]
        public string username { get; set; }
       
        public string password { get; set; }
        public string msg { get; set; }
        
    }
}