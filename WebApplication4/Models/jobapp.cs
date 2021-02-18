using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class jobapp
    {
        [Required(ErrorMessage = "*")]
        public int id { get; set; }
        [Required(ErrorMessage = "*")]
        public string name { get; set; }
        [Required(ErrorMessage = "*")]
        public string place { get; set; }
        [Required(ErrorMessage = "*")]
        public string qualification { get; set; }

        public string msg { get; set; }
    }
}