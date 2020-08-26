using Autofac;
using HealthLab.Framework.AboutLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.AboutModel
{
    public class AboutBaseModel : AdminBaseModel
    {
        protected readonly IAboutService _aboutService;

        public AboutBaseModel(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public AboutBaseModel()
        {
            _aboutService = Startup.AutofacContainer.Resolve<IAboutService>();
        }
    }
}
