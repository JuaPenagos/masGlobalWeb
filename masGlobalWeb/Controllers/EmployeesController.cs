using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using masGlobalWeb.Common.Models;
using masGlobalWeb.Common.Managers;
using masGlobalWeb.Common.Factory;

namespace masGlobalWeb.Controllers
{
    public class EmployeesController : Controller
    {
        
        public List<Employees> EmployeesList = new List<Employees>();
        // GET: Employees
        //public ActionResult Index()
        public async Task<ActionResult> Index()
        {
            ApiServices apiService = new ApiServices();
            EmployeesManager employeesManager = new EmployeesManager();
            EmployeesList = await employeesManager.getEmployees();
            return View(EmployeesList);
        }
        [HttpPost]
        public async Task<ActionResult> Index(string id)
        {
            if (id == "")
            {
                EmployeesManager employeesManager = new EmployeesManager();
                EmployeesList = await employeesManager.getEmployees();
            }
            else 
            {
                EmployeesManager employeesManager = new EmployeesManager();
                EmployeesList = await employeesManager.getEmployees( int.Parse(id));
            }
            return View(EmployeesList);
        }
        
    }
}
