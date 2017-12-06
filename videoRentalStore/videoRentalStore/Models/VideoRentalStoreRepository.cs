using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace videoRentalStore.Models
{
    public class VideoRentalStoreRepository
    {
        VideoRentalStoreDbContext _context = new VideoRentalStoreDbContext();

        public VideoRentalStoreRepository()
        {
            _context.Database.Log = Console.Write;
        }

        /* Get all available Customer */
        public List<Customer> GetAllCustomer()
        {
            List<Customer> customerList =
                (from data in _context.Customers
                 select data).ToList();
            return customerList;
        }

        /* Get Customer's Info */
        public Customer GetCustomerById(int CustomerID)
        {
            Customer customerInfo =
                (from data in _context.Customers
                 where data.ID == CustomerID
                 select data).SingleOrDefault();
            return customerInfo;
        }

        /*Update Customer*/
        public void UpdateCustomer(string firstName, string lastName, string phoneNumber, string Address, int ID)
        {
            Customer customertoUpdate = _context.Customers.Find(ID);
            if(customertoUpdate != null)
            {
                customertoUpdate.FirstName = firstName;
                customertoUpdate.LastName = lastName;
                customertoUpdate.PhoneNumber = phoneNumber;
                customertoUpdate.Address = Address;

                _context.SaveChanges();
            }
        }

        /*Add New Customer*/
        public void AddNewCustomer(string firstName, string lastName, string Address, string phoneNumber)
        {
            Customer c = new Customer();
            
            c.FirstName = firstName;
            c.LastName = lastName;
            c.Address = Address;
            c.PhoneNumber = phoneNumber;

            _context.Customers.Add(c);
            _context.SaveChanges();
            

        }

        public List<Media> GetMediaByTitle(string title)
        {
            List<Media> mediaList =
                (from data in _context.Medias
                 where data.Title.Contains(title)
                 select data).ToList();
            return mediaList;
        }

        public void AddRentalRecord(DateTime rentalDate, List<int> rentedMediaIds, int customerID)
        {
            var medias = (from data in _context.Medias
                          where rentedMediaIds.Contains(data.ID)
                          select data).ToList();

            Rental rental = new Rental();
            rental.RentalDate = rentalDate;
            rental.RentedMedia = medias;

            _context.Rentals.Add(rental);

            var customer = _context.Customers.Find(customerID);
            customer.RentalRecords.Add(rental);
                   
            _context.SaveChanges();
        }

        public void AddNewMedia(string title, string type, string productionYear)
        {
            Media media = new Media();
            media.Title = title;
            media.Type = type;
            media.ProductionYear = productionYear;

            _context.Medias.Add(media);
            _context.SaveChanges();

        }
    }
}