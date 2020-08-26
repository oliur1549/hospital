using Autofac;
using HealthLab.Framework;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IConfiguration _configuration;
        public ServiceController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new ServiceModel();
            return View(model);
        }
        public IActionResult AddService()
        {
            var model = new CreateService();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddService([Bind(nameof(CreateService.ServiceName),
            nameof(CreateService.Description))]
            CreateService model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    model.Response = new ResponseModel("Insert Successfull", ResponseType.Success);
                    return RedirectToAction("Index");
                    
                }
                catch (DuplicationException message)
                {
                    model.Response = new ResponseModel(message.Message, ResponseType.Failure);
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Insert Failed.", ResponseType.Failure);
                    // error logger code
                }

            }
            return View(model);
            
        }
        public IActionResult EditService(int id)
        {
            var model = new UpdateService();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditService([Bind(nameof(UpdateService.Id),
            nameof(UpdateService.ServiceName),
            nameof(UpdateService.Description))]
            UpdateService model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Insert Successfull", ResponseType.Success);
                    return RedirectToAction("index");
                }
                catch (DuplicationException message)
                {
                    model.Response = new ResponseModel(message.Message, ResponseType.Failure);
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Insert Failed.", ResponseType.Failure);
                    // error logger code
                }

            }
            return View(model);
            
        }
        [HttpPost]
        public IActionResult DeleteService(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new ServiceModel();
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
        public IActionResult GetService()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<ServiceModel>();
            var data = model.GetExpense(tableModel);
            return Json(data);
        }
    }
}