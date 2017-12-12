using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidPlace.Models;

namespace VidPlace.ViewModels
{
    public class RentalFormViewModel
    {
        public Customer Customer { get; set; }
        public List<Media> Medias { get; set; }
    }
}