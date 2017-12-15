using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Phono.Models
{
    public class Brand
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string BrandName { get; set; }
        
        public string CountryOfOrigin { get; set; }
        
    }
}