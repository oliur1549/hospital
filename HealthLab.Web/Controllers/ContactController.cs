using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Models.ContactModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IConfiguration _configuration;
        public ContactController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new CreateContact();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(CreateContact model)
        {
            model.Create();
            return View(model);
        }
        
    }
}
