using M_Model_List.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M_Model_List.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee1 = new Employee()
            {
                CodeEmployee = 1,
                FullName = "Marica Kuntong",
                TelePhone = "084-854-7741",
                Mail = "Maraca@Anderyo.com"
            };

            Employee employee2 = new Employee()
            {
                CodeEmployee = 2,
                FullName = "Masunee Julaporn",
                TelePhone = "085-554-9600",
                Mail = "Masunee@Anderyo.com"
            };

            Employee employee3 = new Employee()
            {
                CodeEmployee = 3,
                FullName = "Piliwan Puttan",
                TelePhone = "087-124-5023",
                Mail = "Piliwan@Anderyo.com"
            };

            Employee employee4 = new Employee()
            {
                CodeEmployee = 4,
                FullName = "Pawinee Nanma",
                TelePhone = "087-440-0256",
                Mail = "Pawinee@Anderyo.com"
            };

            Employee employee5 = new Employee()
            {
                CodeEmployee = 5,
                FullName = "Chaiwat Boonnan",
                TelePhone = "089-955-6620",
                Mail = "Chaiwat@Anderyo.com"
            };

            var data = new Employee[5]
            {
                employee1,employee2,employee3,employee4,employee5
            };

            return View(data);
        }
    }
}
