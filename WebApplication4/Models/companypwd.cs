using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class companypwd
    {
        [Required(ErrorMessage = "*")]
        public string oldpwd { get; set; }
        [Required(ErrorMessage = "*")]
        public string newpwd { get; set; }
        [Required(ErrorMessage = "*")]
        public string conpwd { get; set; }

        public string result { get; set; }
    }
}