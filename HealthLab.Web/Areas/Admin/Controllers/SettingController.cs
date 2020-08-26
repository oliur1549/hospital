using System;
using Autofac;
using HealthLab.Framework;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using HealthLab.Web.Areas.Admin.Models.SettingModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly IConfiguration _configuration;

        public SettingController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new SettingModel();
            return View(model);
        }
        public IActionResult AddSetting()
        {
            var model = new CreateSettingModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSetting([Bind(
            nameof(CreateSettingModel.BrowserTitle), 
            nameof(CreateSettingModel.HeaderTitle), 
            nameof(CreateSettingModel.smallImageFile),
            nameof(CreateSettingModel.largeImageFile),
            nameof(CreateSettingModel.Email),
            nameof(CreateSettingModel.FbUrl),
            nameof(CreateSettingModel.Copyright),
            nameof(CreateSettingModel.TermsCondition),
            nameof(CreateSettingModel.Policy)
            )] 
        CreateSettingModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        model.Create();
            //        model.Response = new ResponseModel("Insert Successfull", ResponseType.Success);
            //        return View(model);
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
            model.Create();
            model.Response = new ResponseModel("Insert Successfull", ResponseType.Success);
            return View(model);
        }
        public IActionResult EditSetting(int id)
        {
            var model = new EditSettingModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSetting([Bind(
            nameof(EditSettingModel.Id),
            nameof(EditSettingModel.BrowserTitle),
            nameof(EditSettingModel.HeaderTitle),
            nameof(EditSettingModel.smallImageFile),
            nameof(EditSettingModel.largeImageFile),
            nameof(EditSettingModel.Email),
            nameof(EditSettingModel.FbUrl),
            nameof(EditSettingModel.Copyright),
            nameof(EditSettingModel.TermsCondition),
            nameof(EditSettingModel.Policy)
            )]
        EditSettingModel model)
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
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSetting(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new SettingModel();
                try
                {
                    var delt = model.Remove(id);
                    model.Response = new ResponseModel($"{delt} Deleted successfull", ResponseType.Success);
                    return RedirectToAction("index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Deleted Failed.", ResponseType.Failure);
                }
            }
            return RedirectToAction("index");
        }
        public IActionResult GetSetting()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<SettingModel>();
            var data = model.GetSetting(tableModel);
            return Json(data);
        }
    }
}
