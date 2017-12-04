using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace videoRentalStore.Models
{
    public class VideoRentalStoreRepository
    {
        VideoRentalStoreDbContext _context = new VideoRentalStoreDbContext();

        /* Get all available Customer */
        public List<Customer> getAllCustomer()
        {
            List<Customer> customerList =
                (from data in _context.Customers
                 select data).ToList();
            return customerList;
        }

        /* Get Customer's Info */
        public Customer getCustomerById(int CustomerID)
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
        public void AddNewCustomer(int ID, string firstName, string lastName, string Address, string phoneNumber)
        {
            Customer c = new Customer();
            c.ID = ID;
            c.FirstName = firstName;
            c.LastName = lastName;
            c.Address = Address;
            c.PhoneNumber = phoneNumber;

            _context.Customers.Add(c);
            _context.SaveChanges();
            

        }

        public List<Media> getMediaByTitle(string title)
        {
            List<Media> mediaList =
                (from data in _context.Medias
                 where data.Title == title
                 select data).ToList();
            return mediaList;
        }

        public void addRentalRecord(DateTime rentalDate, List<Media> rentedMedia, int customerID)
        {

        }
    }
}