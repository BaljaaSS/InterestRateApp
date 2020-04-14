using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RateApp.Core
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Term { get; set; }
        [Required]
        public double OneTime{ get; set; }
        [Required]
        public double Monthly { get; set; }
    }
}
