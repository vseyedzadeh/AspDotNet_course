using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PhoneOnlineShop.Models
{
    public class PhoneType
    {
        public byte ID { get; set; }

        [Required][MaxLength(255)]
        public string Type { get; set; }

        [Required][MaxLength(255)]
        public string OS { get; set; }
    }
}