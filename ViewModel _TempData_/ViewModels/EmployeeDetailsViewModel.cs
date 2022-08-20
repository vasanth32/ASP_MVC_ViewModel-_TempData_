using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModel__TempData_.Models;

namespace ViewModel__TempData_.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
    }
}