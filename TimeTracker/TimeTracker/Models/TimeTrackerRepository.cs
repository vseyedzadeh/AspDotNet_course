using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    
    public class TimeTrackerRepository
    {
        TimeTrackerDBContext _context = new TimeTrackerDBContext();

        /*
         *  this methods gets the records of all employees 
         */
        public List<Employee> getallEmployees()
        {
            List<Employee> allEmps =
                (from data in _context.Employees
                 select data).ToList();
            return allEmps;
        }

        public List<TimeCard> getEmployeeTimeCards(int empId)
        {
            List<TimeCard> employeeTimes =
                (from data in _context.Employees
                 where data.ID == empId 
                 select data.timeCards).SingleOrDefault();

            return employeeTimes;
                
        }

        public List<string> getDepartmentList()
        {
            List<string> departmentList =
                 (from data in _context.Employees
                  select data.Department).Distinct().ToList();
            return departmentList;
        }

        public List<Employee> getDepartmentsEmployees(string department)
        {
            List<Employee> employeeList =
                (from data in _context.Employees
                 where data.Department == department
                 select data).ToList();
            return employeeList;
        }

        public Employee getEmployee(int empId)
        {
            Employee employee =
                (from data in _context.Employees
                 where data.ID == empId
                 select data).SingleOrDefault();
            return employee;
        }

        public void insertEmployee(int ID, string firstName, string lastName, string department, DateTime hireDate)
        {
            Employee e = new Employee();
            e.ID = ID;
            e.FirstName = firstName;
            e.LastName = lastName;
            e.Department = department;
            e.HireDate = hireDate;

            _context.Employees.Add(e);
            _context.SaveChanges();
            
        }
        
    }

    
}