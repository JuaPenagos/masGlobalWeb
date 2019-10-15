using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using masGlobalWeb.Common.Models;
using masGlobalWeb.Common.Managers;


namespace masGlobalWeb.Common.Factory
{
    public class EmployeesFactory
    {
        public Employees GetEmployeesSalary(Employees employee ) {


            switch (employee.roleId)
            {
                case 1:
                    EmployeeHourlySalaryContract employeeHourlySalaryContract = new EmployeeHourlySalaryContract();
                    employeeHourlySalaryContract.name = employee.name;
                    employeeHourlySalaryContract.hourlySalary = employee.hourlySalary;
                    employeeHourlySalaryContract.monthlySalary = employee.monthlySalary;
                    employeeHourlySalaryContract.id = employee.id;
                    employeeHourlySalaryContract.roleId = employee.roleId;
                    employeeHourlySalaryContract.roleName = employee.roleName;
                    employeeHourlySalaryContract.roleDescription = employee.roleDescription;
                    employeeHourlySalaryContract.getAnualSalary();
                    return employeeHourlySalaryContract;
                case 2:
                    EmployeeMonthlySalaryContract employeeMonthlySalaryContract = new EmployeeMonthlySalaryContract();
                    employeeMonthlySalaryContract.name = employee.name;
                    employeeMonthlySalaryContract.monthlySalary = employee.monthlySalary;
                    employeeMonthlySalaryContract.hourlySalary = employee.hourlySalary;
                    employeeMonthlySalaryContract.id = employee.id;
                    employeeMonthlySalaryContract.roleId = employee.roleId;
                    employeeMonthlySalaryContract.roleName = employee.roleName;
                    employeeMonthlySalaryContract.roleDescription = employee.roleDescription;
                    employeeMonthlySalaryContract.getAnualSalary();
                    return employeeMonthlySalaryContract;
                default:
                    return null;
            }
        }
    }
}