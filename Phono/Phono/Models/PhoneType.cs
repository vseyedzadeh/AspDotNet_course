using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Phono.Models
{
    public class PhoneType
    {
        public byte Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Type { get; set; }

        [Required]
        [MaxLength(255)]
        public string OS { get; set; }
    }
}