using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class profileClass1
    {
        [Required(ErrorMessage = "*")]
        public string name { get; set; }
        [Required(ErrorMessage = "*")]
        public int age { get; set; }
        [Required(ErrorMessage = "*")]
        public string qualification { get; set; }
        [Required(ErrorMessage = "*")]
        public string passoutyear { get; set; }
        [Required(ErrorMessage = "*")]
        public string email { get; set; }

        public string msg { get; set; }
    }
}