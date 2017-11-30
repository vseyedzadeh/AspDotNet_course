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
    }
}