using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIDemo.Service.Models
{
    public class NumberEntity
    {
        [Required]
        public int Number { get; set; }
        [Required]
        public int Divisor { get; set; }
        public int? Result { get; set; }
    }
}