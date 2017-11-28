using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthWND_Object.Data_La;

namespace NorthWND_Object.BAL_La
{
    public class BAL_NorthWNd
    {
        /*
         
         */
        public List<string> getCountries()
        {
            using (var context = new DataClasses1DataContext())
            {
                List<string> countries = (from data in context.Customers
                                          select data.Country).Distinct().ToList();

                return countries;
            }
        }

        public List<Customer> getAllCustomers(string country)
        {
            using (var context = new DataClasses1DataContext())
            {
                List<Customer> customer = (from data in context.Customers
                                           where data.Country == country
                                           select data).ToList();

                return customer;
            }
        }

       
    }
}