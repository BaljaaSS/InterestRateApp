using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Text;

namespace RateApp.Core
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? Term { get; set; }
        [Required]
        public decimal? OneTime{ get; set; }
        [Required]
        public decimal? Monthly { get; set; }
    }
}
