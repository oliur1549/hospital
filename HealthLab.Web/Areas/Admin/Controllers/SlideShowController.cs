using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using HealthLab.Framework;
using HealthLab.Framework.SlideShowLab;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using HealthLab.Web.Areas.Admin.Models.SlideModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlideShowController : Controller
    {
        private readonly IConfiguration _configuration;
        
        public SlideShowController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new SlideShowModel();
            return View(model);
        }
        public IActionResult AddSlide()
        {
            var model = new CreateSlideShow();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSlide([Bind(nameof(CreateSlideShow.imageFile),
            nameof(CreateSlideShow.Title), 
            nameof(CreateSlideShow.Description), 
            nameof(CreateSlideShow.Status))] 
        CreateSlideShow model)
        {

            model.Create();
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
        public IActionResult EditSlide(int id)
        {
            var model = new EditSlideShow();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSlide([Bind(nameof(EditSlideShow.Id), nameof(EditSlideShow.imageFile), nameof(EditSlideShow.Title), nameof(EditSlideShow.Description), nameof(EditSlideShow.Status))] EditSlideShow model)
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
        public IActionResult DeleteSlide(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new SlideShowModel();
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
        public IActionResult GetSlideShow()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<SlideShowModel>();
            var data = model.GetSlideShow(tableModel);
            return Json(data);
        }
    }
}