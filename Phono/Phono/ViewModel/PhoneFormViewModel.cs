using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Phono.Models;

namespace Phono.ViewModel
{
    public class PhoneFormViewModel
    {
        public Phone Phone { get; set; }
        public List<Brand> BrandsList { get; set; }
        public List<PhoneType> PhoneTypesList { get; set; }

        public string Title
        {
            get
            {
                return Phone.ID == 0 ? "New Phone" : "Edit Phone";
            }
        }

        public PhoneFormViewModel()
        {
            Phone = new Phone();
            Phone.ID = 0;
        }
    }
}