using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneOnlineShop.Models
{
    public class Phone
    {
        public byte ID { get; set; }

        [Required][MaxLength(255)]
        public string PhoneName { get; set; }

        [Required]
        public Brand Brand { get; set; }
        public byte Brand_ID { get; set; }

        public DateTime DateReleased { get; set; }

        public string ScreenSize { get; set; }

        public PhoneType PhoneType { get; set; }
        public byte PhoneType_ID { get; set; }
    }
}