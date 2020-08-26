using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthLab.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateDept()
        {
            var model = new CreateDepartment();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateDept(CreateDepartment model)
        {
            model.Create();
            return View(model);
        }
    }
}