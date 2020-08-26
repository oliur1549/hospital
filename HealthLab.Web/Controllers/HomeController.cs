using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthLab.Web.Models;
using HealthLab.Framework.SlideShowLab;
using HealthLab.Framework;
using HealthLab.Web.Models.Appointments;
using Microsoft.Extensions.Configuration;

namespace HealthLab.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private DatabaseContext _databaseContext;
        public HomeController(IConfiguration configuration, DatabaseContext databaseContext)
        {
            _configuration = configuration;
            _databaseContext = databaseContext;
        }
        public IActionResult Index()
        {
            ViewBag.isHome = true;
            var services = _databaseContext.services.OrderByDescending(p => p.Id).ToList();
            ViewBag.Services = services;
            var slideShow = _databaseContext.SlideShows.Where(p=>p.Status).Take(3).ToList();
            ViewBag.SlideShow = slideShow;
            var about = _databaseContext.abouts.Take(1);
            ViewBag.About = about;
            var gallery = _databaseContext.Galleries.OrderByDescending(g => g.Id).Take(8).ToList();
            ViewBag.Gallery = gallery;
            var doctor = _databaseContext.Doctors.Take(3).ToList();
            ViewBag.Doctor = doctor;
            var blog = _databaseContext.Blogs.OrderByDescending(b => b.Datetime).Take(3).ToList();
            ViewBag.Blog = blog;
            var footer = _databaseContext.Address.Take(1);
            ViewBag.Footer = footer;
            
            return View();
        }
        

    }
}
