using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace videoRentalStore.Models
{
    public class Media
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string ProductionYear { get; set; }
    }
}