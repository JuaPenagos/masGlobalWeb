using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using masGlobalWeb.Common.Models;

namespace masGlobalWeb.Common.Managers
{
    public class EmployeeHourlySalaryContract : Employees
    {
        public void getAnualSalary()
        {
            anualSalary =  120 * hourlySalary * 12;
        }

    }
}