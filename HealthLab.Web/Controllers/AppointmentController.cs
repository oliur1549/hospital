using HealthLab.Web.Models;
using HealthLab.Web.Models.Appointments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IConfiguration _configuration;
        public AppointmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new CreateAppointment();
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Index(CreateAppointment model)
        {
            model.Create();
            return View(model);
        }
    }
}