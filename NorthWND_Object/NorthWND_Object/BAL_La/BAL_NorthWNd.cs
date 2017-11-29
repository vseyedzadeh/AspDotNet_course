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

        public List<Customer> getCustomers(String fieldName, String value)
        {
            using (var context = new DataClasses1DataContext())
            {
                return context.ExecuteQuery<Customer>("SELECT * FROM customers WHERE " + fieldName + " = {0}", value).ToList();
            }
        }

        public List<Field> getFields()
        {
            //return (from p in typeof(Customer).GetProperties()
            //        select new Field { Name = p.Name }).ToList();
            using (var context = new DataClasses1DataContext())
            {
                return (from x in context.ExecuteQuery<String>("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('Customers')")
                        select new Field { Name = x }).ToList();
            }
        }

        public class Field
        {
            public string Name { get; set; }
        }
    }
}