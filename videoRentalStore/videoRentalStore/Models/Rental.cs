using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace videoRentalStore.Models
{
    public class Rental
    {
        public int ID { get; set; }
        public DateTime RentalDate { get; set; }
        public List<Media> rentedMedia { get; set; }

    }
}