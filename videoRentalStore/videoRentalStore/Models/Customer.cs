﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace videoRentalStore.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Rental> RentalRecords { get; set; }

    }
}