using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthWND.Data;

namespace NorthWND.BAL
{
    public class BAL_NorthWND
    {
        /*
         * This method returns a list of distinct countries from the customer table in the northwind DB
         *          
        */
        public List<string> getCountries()
        {
            using (var context = new NorthWNDDataContext())
            {
                List<string> myList = (from data in context.Customers
                                       select data.Country).Distinct().ToList();
                return myList;

            }
        }

        /*
         */
        public List<Customer> getAllCustomers(string country)
        {
            using (var context = new NorthWNDDataContext())
            {
                List<Customer> allCustomers = (from data in context.Customers
                                               where data.Country == country
                                               select data).ToList();
                return allCustomers;
            }


        }

        public Customer getCustomer(string customerID)
        {
            using (var context = new NorthWNDDataContext())
            {
                Customer selectedCutsomer = (from data in context.Customers
                                                   where data.CustomerID == customerID
                                                   select data).SingleOrDefault();
                return selectedCutsomer;

            }
        }
    }
}