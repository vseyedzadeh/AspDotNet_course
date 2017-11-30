using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace videoRentalStore.Models
{
    public class VideoRentalStoredbcontextInitializer : DropCreateDatabaseIfModelChanges<VideoRentalStoreDbContext>
    {
        protected override void Seed(VideoRentalStoreDbContext context)
        {
            Customer tempCustomer = new Customer();
            tempCustomer.FirstName = "Mehrshad";
            tempCustomer.LastName = "Shams";
            tempCustomer.PhoneNumber = "4385555555";
            tempCustomer.Address = "1020 Berry street";

            List<Media> rentedMediaList = new List<Media>
            {
                new Media { ID = 1, Title = "Title 1", Type  = "Movie", ProductionYear = "1985"},
                new Media { ID = 2, Title = "Title 2", Type  = "Movie", ProductionYear = "1965"},
                new Media { ID = 3, Title = "Title 3", Type  = "TV Show", ProductionYear = "1988"}
            };

            List<Rental> Rentals = new List<Rental>
            {
                new Rental { ID = 1 , RentalDate = DateTime.Now, rentedMedia = rentedMediaList}
            };

            tempCustomer.rentalRecords = Rentals;

            context.Customers.Add(tempCustomer);

            base.Seed(context);
            
           
                }
    }
}