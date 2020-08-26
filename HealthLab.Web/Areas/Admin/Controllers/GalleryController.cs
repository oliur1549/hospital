using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using HealthLab.Framework;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.GalleryModel;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GalleryController : Controller
    {
        private readonly IConfiguration _configuration;

        public GalleryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new GalleryModel();
            return View(model);
        }
        public IActionResult AddGallery()
        {
            var model = new CreateGalleryModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGallery([Bind(
            nameof(CreateGalleryModel.imageFile),
            nameof(CreateGalleryModel.Title))]
        CreateGalleryModel model)
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
        public IActionResult EditGallery(int id)
        {
            var model = new EditGalleryModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditGallery([Bind(
            nameof(EditGalleryModel.imageFile),
            nameof(EditGalleryModel.Title))]
        EditGalleryModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Update Successfull", ResponseType.Success);
                    return RedirectToAction("index");
                }
                catch (DuplicationException message)
                {
                    model.Response = new ResponseModel(message.Message, ResponseType.Failure);
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Update Failed.", ResponseType.Failure);
                    // error logger code
                }

            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteAbout(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new GalleryModel();
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
        public IActionResult GetGallery()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<GalleryModel>();
            var data = model.GetGallery(tableModel);
            return Json(data);
        }
    }
}
