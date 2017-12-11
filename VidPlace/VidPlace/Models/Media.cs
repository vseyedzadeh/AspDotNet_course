using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Media
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name="Media Name")]
        public string Name { get; set; }

        /*
         * to avoid the datetime element to be pre-initialized
         * Make it required and add "?" to let be null
         * */
        [Display(Name="Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Range(0,999, ErrorMessage ="Number In Stock has to be more than zero")]
        [Display(Name="Number is stock")]
        public int NumberInStock { get; set; }

        public MediaType MediaType { get; set; }
        [Required]
        [Display(Name="Media Type")]
        public int MediaTypeID { get; set; }


        public Genre Genre { get; set; }
        [Required]
        [Display(Name="Genre")]
        public int GenreID { get; set; }


        //override tostring method
        public override string ToString()
        {
            return "Media name: " + Name ;
        }

    }
}