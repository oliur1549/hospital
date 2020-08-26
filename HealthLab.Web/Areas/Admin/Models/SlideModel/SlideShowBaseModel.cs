using Autofac;
using HealthLab.Framework.SlideShowLab;
using Microsoft.AspNetCore.Hosting;
using System;

namespace HealthLab.Web.Areas.Admin.Models.SlideModel
{
    public class SlideShowBaseModel : AdminBaseModel
    {
        protected readonly ISlideService _slideService;
        
        public SlideShowBaseModel(ISlideService slideService)
        {
            _slideService = slideService;
           
        }

        public SlideShowBaseModel()
        {
            _slideService = Startup.AutofacContainer.Resolve<ISlideService>();
        }

    }
}
