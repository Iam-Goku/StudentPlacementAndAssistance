using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class jobs
    {
        [Required(ErrorMessage = "enter id")]
        public int id { get; set; }
        [Required(ErrorMessage = "enter job title")]
        public string jobtitle { get; set; }
        [Required(ErrorMessage = "enter experiance in years")]
        public int experiance { get; set; }
        [Required(ErrorMessage = "enter vaccancies")]
        public string vaccancies { get; set; }
        [Required(ErrorMessage = "enter contact number")]
        public string contactnumber { get; set; }
        [Required(ErrorMessage = "enter email")]
        public string email { get; set; }
        public string msg { get; set; }
    }
}