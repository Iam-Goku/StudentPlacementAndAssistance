using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class intern
    {
        [Required(ErrorMessage = "enter id")]
        public int id { get; set; }
        [Required(ErrorMessage = "enter amount")]
        public string amount { get; set; }
        [Required(ErrorMessage = "enter duration")]
        public string duration { get; set; }
        [Required(ErrorMessage = "enter internship name")]
        public string internshipname { get; set; }
        [Required(ErrorMessage = "enter contact number")]
        public string contactnumber { get; set; }
        [Required(ErrorMessage = "enter Eamil")]
        public string email { get; set; }

        public string msg { get; set; }
    }
}