using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using masGlobalWeb.Common.Models;


namespace masGlobalWeb.Common.Managers
{
    public class EmployeeMonthlySalaryContract : Employees
    {
        public void getAnualSalary() 
        {
        anualSalary = monthlySalary * 12;
        }  
    }
}