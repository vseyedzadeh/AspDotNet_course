using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Phono.Models;

namespace Phono.ViewModel
{
    public class BrnadsPhoneViewModel
    {
        public Brand Brand { get; set; }
        public List<Phone> Phone { get; set; }
    }
}