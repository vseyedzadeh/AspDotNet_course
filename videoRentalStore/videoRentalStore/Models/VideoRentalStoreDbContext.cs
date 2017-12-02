using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace videoRentalStore.Models
{
    public class VideoRentalStoreDbContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}