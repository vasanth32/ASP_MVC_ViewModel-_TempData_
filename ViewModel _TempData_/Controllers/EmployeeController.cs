using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel__TempData_.Models;
using ViewModel__TempData_.ViewModels;

namespace ViewModel__TempData_.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Details()
        {
            //Employee Basic Details
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Dillip",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };

            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Bhubaneswar",
                State = "Odisha",
                Country = "India",
                Pin = "755019"
            };

            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };

            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }

        public ActionResult Method1()
        {
            TempData["Name"] = "Pranaya";
            TempData["Age"] = 30;
            return View();
        }
        public ActionResult Method2()
        {
            string Name;
            int Age;
            if (TempData.ContainsKey("Name"))
                Name = TempData["Name"].ToString();
            if (TempData.ContainsKey("Age"))
                Age = int.Parse(TempData["Age"].ToString());
            TempData.Keep();
            // do something with userName or userAge here 
            return View();
        }
        public ActionResult Method3()
        {
            string Name;
            int Age;
            if (TempData.ContainsKey("Name"))
                Name = TempData["Name"].ToString();
            if (TempData.ContainsKey("Age"))
                Age = int.Parse(TempData["Age"].ToString());
            // do something with userName or userAge here 
            return View();
        }
    }
}