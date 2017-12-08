using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phono.Models
{
    public class Phone
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string PhoneName { get; set; }

        [Required]
        public Brand Brand { get; set; }
        public byte BrandId { get; set; }

        [Required]
        public DateTime DateReleased { get; set; }

        [Required]
        public string ScreenSize { get; set; }

        [Required]
        public PhoneType PhoneType { get; set; }
        public byte PhoneTypeId { get; set; }
    }
}