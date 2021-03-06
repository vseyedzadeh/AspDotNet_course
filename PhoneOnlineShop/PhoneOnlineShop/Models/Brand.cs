﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PhoneOnlineShop.Models
{
    public class Brand
    {
        public byte ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string BrandName { get; set; }

        [Required]
        public string CountryOfOrigin { get; set; }
    }
}