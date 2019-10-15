using masGlobalWeb.Common.Factory;
using masGlobalWeb.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace masGlobalWeb.Common.Managers
{
    public class EmployeesManager
    {
        public List<Employees> EmployeesList = new List<Employees>();
        public async Task<List<Employees>> LoadEmployees()
        {
            ApiServices apiService = new ApiServices();
            var url = "http://masglobaltestapi.azurewebsites.net";
            var prefix = "/api";
            var controller = "/Employees";
            var response = await apiService.GetList<Employees>(url, prefix, controller); 
            if (response.IsSuccess)
            {
                Employees employePrueba = new Employees();
                foreach (Employees employe in (List<Employees>)response.Result)
                {
                    EmployeesFactory employeFactry = new EmployeesFactory();
                    EmployeesList.Add(employeFactry.GetEmployeesSalary(employe));
                }
            };
            return EmployeesList;

        }
        public async Task<List<Employees>> getEmployees()
        {
            ApiServices apiService = new ApiServices();
            var url = "http://localhost:52868";
            var prefix = "/api";
            var controller = "/Employees";
            var response = await apiService.GetList<Employees>(url, prefix, controller);
            if (response.IsSuccess)
            {
                Employees employePrueba = new Employees();
                foreach (Employees employe in (List<Employees>)response.Result)
                {
                    EmployeesFactory employeFactry = new EmployeesFactory();
                    EmployeesList.Add(employeFactry.GetEmployeesSalary(employe));
                }
            };
            return EmployeesList;
        }
        public async Task<List<Employees>> getEmployees(int id)
        {
            ApiServices apiService = new ApiServices();
            var url = "http://localhost:52868";
            var prefix = "/api";
            var controller = "/Employees";
            var response = await apiService.GetList<Employees>(url, prefix, controller,id);
            if (response.IsSuccess)
            {
                Employees employePrueba = new Employees();
                foreach (Employees employe in (List<Employees>)response.Result)
                {
                    EmployeesFactory employeFactry = new EmployeesFactory();
                    EmployeesList.Add(employeFactry.GetEmployeesSalary(employe));
                }
            };
            return EmployeesList;

        }
    }
}