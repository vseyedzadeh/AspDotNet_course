using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TimeTracker.Models
{
    //don't do it in the real world
    public class TimeTrackerDBContextInitializer : DropCreateDatabaseIfModelChanges<TimeTrackerDBContext>
    {
        protected override void Seed(TimeTrackerDBContext context)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.ID = 1;
            tempEmployee.FirstName = "Barry";
            tempEmployee.LastName = "Allen";
            tempEmployee.Department = "IT";
            tempEmployee.HireDate = DateTime.Now.AddDays(-14);

            List<TimeCard> timeCards = new List<TimeCard>
            {
                new TimeCard{ ID = 1, submissionDate = DateTime.Now,
                MondayHours = 8, TuesdayHours = 9, WednesdayHours = 6, ThursdayHours = 8, FridayHours = 10, SaturdayHours = 0, SundayHours = 0},

                 new TimeCard{ ID = 1, submissionDate = DateTime.Now.AddDays(-7),
                MondayHours = 10, TuesdayHours = 10, WednesdayHours = 6, ThursdayHours = 8, FridayHours = 10, SaturdayHours = 0, SundayHours = 3}
            };

            tempEmployee.timeCards = timeCards;

            context.Employees.Add(tempEmployee);

            base.Seed(context);
        }

    }
}