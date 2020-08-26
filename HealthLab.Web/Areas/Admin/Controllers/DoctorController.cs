using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using HealthLab.Framework;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.DoctorModel;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DoctorController : Controller
    {
        private readonly IConfiguration _configuration;

        public DoctorController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new DoctorModel();
            return View(model);
        }
        public IActionResult AddDoctor()
        {
            var model = new CreateDoctorModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDoctor([Bind(nameof(CreateDoctorModel.Name),
            nameof(CreateDoctorModel.imageFile),
            nameof(CreateDoctorModel.Phone),
            nameof(CreateDoctorModel.Address))]
        CreateDoctorModel model)
        {
            model.Create();
            model.Response = new ResponseModel("Insert Successfull", ResponseType.Success);
            return RedirectToAction("index");
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        model.Create();
            //        model.Response = new ResponseModel("Insert Successfull", ResponseType.Success);
            //        return RedirectToAction("index");
            //    }
            //    catch (DuplicationException message)
            //    {
            //        model.Response = new ResponseModel(message.Message, ResponseType.Failure);
            //    }
            //    catch (Exception ex)
            //    {
            //        model.Response = new ResponseModel("Insert Failed.", ResponseType.Failure);
            //        // error logger code
            //    }

            //}
            //return View(model);
        }
        public IActionResult EditDoctor(int id)
        {
            var model = new EditDoctorModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditDoctor([Bind(
            nameof(EditDoctorModel.Id),
            nameof(EditDoctorModel.Name),
            nameof(EditDoctorModel.imageFile),
            nameof(EditDoctorModel.Phone),
            nameof(EditDoctorModel.Address))]
        EditDoctorModel model)
        {
            model.Edit();
            model.Response = new ResponseModel("Update Successfull", ResponseType.Success);
            return RedirectToAction("index");
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        model.Edit();
            //        model.Response = new ResponseModel("Update Successfull", ResponseType.Success);
            //        return RedirectToAction("index");
            //    }
            //    catch (DuplicationException message)
            //    {
            //        model.Response = new ResponseModel(message.Message, ResponseType.Failure);
            //    }
            //    catch (Exception ex)
            //    {
            //        model.Response = new ResponseModel("Update Failed.", ResponseType.Failure);
            //        // error logger code
            //    }

            //}
            //return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDoctor(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new DoctorModel();
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
        public IActionResult GetDoctor()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<DoctorModel>();
            var data = model.GetDoctor(tableModel);
            return Json(data);
        }
    }
}
