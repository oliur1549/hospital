using Autofac;
using HealthLab.Framework.Menu;
using HealthLab.Web.Areas.Admin.Models.ResponseMessage;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models
{
    public class AdminBaseModel
    {
        public MenuModel MenuModel { get; set; }

        public ResponseModel Response
        {
            get
            {
                if (_httpContextAccessor.HttpContext.Session.IsAvailable
                    && _httpContextAccessor.HttpContext.Session.Keys.Contains(nameof(Response)))
                {
                    var response = _httpContextAccessor.HttpContext.Session.Get<ResponseModel>(nameof(Response));
                    _httpContextAccessor.HttpContext.Session.Remove(nameof(Response));

                    return response;
                }
                else
                    return null;
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.Set(nameof(Response),
                    value);
            }
        }

        protected IHttpContextAccessor _httpContextAccessor;
        public AdminBaseModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            SetupMenu();
        }

        public AdminBaseModel()
        {
            _httpContextAccessor = Startup.AutofacContainer.Resolve<IHttpContextAccessor>();
            SetupMenu();
        }
        private void SetupMenu()
        {
            MenuModel = new MenuModel
            {
                MenuItems = new List<MenuItems>
                {
                    {
                        new MenuItems
                        {
                            Title = "Service",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Service", Url = "/Admin/Service" },
                                new MenuChildItem{ Title = "Add Service", Url ="/Admin/Service/AddService"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Slide",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Slide", Url = "/Admin/SlideShow" },
                                new MenuChildItem{ Title = "Add Slide", Url ="/Admin/SlideShow/AddSlide"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "About",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View About", Url = "/Admin/About" },
                                new MenuChildItem{ Title = "Add About", Url ="/Admin/About/AddAbout"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Gallery",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Gallery", Url = "/Admin/Gallery" },
                                new MenuChildItem{ Title = "Add Gallery", Url ="/Admin/Gallery/AddGallery"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Doctor",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Doctor", Url = "/Admin/Doctor" },
                                new MenuChildItem{ Title = "Add Doctor", Url ="/Admin/Doctor/AddDoctor"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Address",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Address", Url = "/Admin/Address" },
                                new MenuChildItem{ Title = "Add Address", Url ="/Admin/Address/AddAddress"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Blog",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Blog", Url = "/Admin/Blog" },
                                new MenuChildItem{ Title = "Add Blog", Url ="/Admin/Blog/AddBlog"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Setting",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Setting", Url = "/Admin/Setting" },
                                new MenuChildItem{ Title = "Add Setting", Url ="/Admin/Setting/AddSetting"}
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Contacts",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Contacts", Url = "/Admin/Contacts" }
                            }
                        }
                    },
                    {
                        new MenuItems
                        {
                            Title = "Appointment",
                            menuChildItems = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Appointment", Url = "/Admin/Appointment" }
                            }
                        }
                    }

                }
            };
        }
    }
}
