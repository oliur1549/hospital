using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthLab.Web.Areas.Admin.Models.TimeModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class TimeController : Controller
    {
        private readonly IConfiguration _configuration;

        public TimeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new CreateTimeModel();
            model.Create();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateTime()
        {
            var model = new CreateTimeModel();
            model.Create();
            return View(model);
        }
    }
}
