using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phono.Models
{
    public class Phone
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Phone Name")]
        public string PhoneName { get; set; }

        public Brand Brand { get; set; }
        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        [Display(Name = "Date Released")]
        public DateTime? DateReleased { get; set; }

        [Range(2, 7)]
        [Display(Name = "Screen size")]
        public float? ScreenSize { get; set; }
                        
        public PhoneType PhoneType { get; set; }
        [Required]
        [Display(Name = "Phone Type")]
        public int PhoneTypeId { get; set; }

        public override string ToString()
        {
            return "Phone name: " + PhoneName;
        }
    }
}