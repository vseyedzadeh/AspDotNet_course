using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam1.DATA;

namespace Exam1.BAL
{
    public class BAL_NorthWND
    {
        public List<Order> getOrders(DateTime orderDate)
        {
            using (var context = new NorthWNDDataContext())
            {
                List<Order> orderList = (from data in context.Orders
                                                where data.OrderDate == orderDate
                                         select data).ToList();
                return orderList;

            }
        }

        public List<Customer> getCustomerDetail(string customerID)
        {
            using (var context = new NorthWNDDataContext())
            {
                List<Customer> customerList = (from data in context.Customers
                                         where data.CustomerID == customerID
                                         select data).ToList();
                return customerList;

            }
        }
    }
}