using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TimeTracker.Models
{
    public class TimeTrackerDBContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeCard> TimetCards { get; set; }
    }
}