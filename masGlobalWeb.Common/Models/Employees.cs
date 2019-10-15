using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace masGlobalWeb.Common.Models
{
    public class Employees
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Contract")]
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        [Display(Name = "Role")]
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public double hourlySalary { get; set; }
        public double monthlySalary { get; set; }
        [Display(Name = "Anual Salary")]
        public double anualSalary { get; set; }
    }
}