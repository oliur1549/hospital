using HealthLab.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new AdminBaseModel();
            return View(model);
        }
    }
}