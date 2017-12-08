using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Phono.Models
{
    public class Brand
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string BrandName { get; set; }

        [Required]
        public string CountryOfOrigin { get; set; }
    }
}