using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class companyprof
    {
        [Required(ErrorMessage = "*")]
        public string companyname { get; set; }
        [Required(ErrorMessage = "*")]
        public string address { get; set; }
        [Required(ErrorMessage = "*")]
        public string phone { get; set; }
        [Required(ErrorMessage = "*")]
        public string email { get; set; }
        [Required(ErrorMessage = "*")]
        public string msg { get; set; }
    }
}