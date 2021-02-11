using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class comp
    {
        [Required(ErrorMessage = "Enter id")]
        public int id { get; set; }
        [Required(ErrorMessage = "Enter company name")]

        public string compname { get; set; }
        [Required(ErrorMessage = "Enter address")]

        public string address { get; set; }
        [Required(ErrorMessage = "Enter phone")]

        public string phone { get; set; }
        [Required(ErrorMessage = "Enter email")]

        public string email { get; set; }
        [Required(ErrorMessage = "Enter password")]

        public string password { get; set; }
        public string msg { get; set; }
    }
}