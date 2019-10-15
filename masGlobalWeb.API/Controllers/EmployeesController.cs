using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using masGlobalWeb.Common.Models;
using masGlobalWeb.Common.Factory;
using masGlobalWeb.Common.Managers;
using System.Threading.Tasks;

namespace masGlobalWeb.API.Controllers
{
    public class EmployeesController : ApiController
    {
        ApiServices api = new ApiServices();
        public List<Employees> EmployeesList = new List<Employees>();
        // GET: api/Employees
        public async Task<IHttpActionResult> GetEmployees()
        {
            EmployeesManager employeesManager = new EmployeesManager();
            EmployeesList = await employeesManager.LoadEmployees();
            return Ok(EmployeesList);   
        }

        // GET: api/Employees/5
        public async Task<IHttpActionResult> GetEmployees(int id)
        {
            EmployeesManager employeesManager = new EmployeesManager();
            EmployeesList = await employeesManager.LoadEmployees();
            return Ok(EmployeesList.Where(x => x.id == id).ToList());            
        }
    }
}
