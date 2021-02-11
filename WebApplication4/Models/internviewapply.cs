using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class internviewapply
    {
        [Required(ErrorMessage = "*")]
        public int id { get; set; }
        [Required(ErrorMessage = "*")]
        public string amount { get; set; }
        [Required(ErrorMessage = "*")]
        public int duration { get; set; }
        [Required(ErrorMessage = "*")]
        public string internshipname { get; set; }
        [Required(ErrorMessage = "*")]
        public string contactnumber { get; set; }
        [Required(ErrorMessage = "*")]
        public string email { get; set; }

        public string msg { get; set; }
    }
}