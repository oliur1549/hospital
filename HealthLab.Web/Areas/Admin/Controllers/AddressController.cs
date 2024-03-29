﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using HealthLab.Framework;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.AboutModel;
using HealthLab.Web.Areas.Admin.Models.AddressModel;
using HealthLab.Web.Areas.Admin.Models.BlogModel;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddressController : Controller
    {
        private readonly IConfiguration _configuration;

        public AddressController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new AddressModel();
            return View(model);
        }
        public IActionResult AddAddress()
        {
            var model = new CreateAddressModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAddress([Bind(
            nameof(CreateAddressModel.Address), 
            nameof(CreateAddressModel.Email),
            nameof(CreateAddressModel.Phone),
            nameof(CreateAddressModel.Description),
            nameof(CreateAddressModel.Hotline))]
        CreateAddressModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
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
        public IActionResult EditAddress(int id)
        {
            var model = new EditAddressModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAddress([Bind(
            nameof(EditAddressModel.Id),
            nameof(EditAddressModel.Address),
            nameof(EditAddressModel.Email),
            nameof(EditAddressModel.Phone),
            nameof(EditAddressModel.Description),
            nameof(EditAddressModel.Hotline))]
        EditAddressModel model)
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
        public IActionResult DeleteAddress(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new AddressModel();
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
        public IActionResult GetAddress()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<AddressModel>();
            var data = model.GetAddress(tableModel);
            return Json(data);
        }
    }
}
