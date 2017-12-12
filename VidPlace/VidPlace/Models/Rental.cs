using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

        //Customer has a 1-* relation with rental
        //One rental belongs to one customer 
        //One customer will have several rentals
        public Customer Customer { get; set; }

        [Required]
        public int CustomerId { get; set; }

        //Media has a *-* relation with rentals
        //A rental can have several medias and media can be part of several rentals
        public virtual List<Media> Medias { get; set; }
    }
}