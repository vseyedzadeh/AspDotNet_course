using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    
    public class TimeTrackerRepository
    {
        TimeTrackerDBContext _context = new TimeTrackerDBContext();
        public List<Employee> getallEmployees()
        {
            List<Employee> allEmps =
                (from data in _context.Employees
                 select data).ToList();
            return allEmps;
        }

        
    }
}