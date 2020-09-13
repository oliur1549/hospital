using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.AppointmentModel;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AppointmentController : Controller
    {
        private readonly IConfiguration _configuration;

        public AppointmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new AppointmentModel();
            return View(model);
        }
        public IActionResult GetAppointment()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<AppointmentModel>();
            var data = model.GetAppointment(tableModel);
            return Json(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var model = new AppointmentModel();
                try
                {
                    var delt = model.Remove(id);
                    model.Response = new ResponseModel($"{delt} Deleted successfull", ResponseType.Success);
                    return RedirectToAction("index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Insert Failed.", ResponseType.Failure);
                }
            }
            return RedirectToAction("index");
        }
    }
}
