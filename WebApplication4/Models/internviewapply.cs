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
        public string name { get; set; }
        [Required(ErrorMessage = "*")]
        public string place { get; set; }
        [Required(ErrorMessage = "*")]
        public string qulificaiton { get; set; }
  
        public string msg { get; set; }
    }
}