using Autofac;
using HealthLab.Framework.GalleryLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.GalleryModel
{
    public class GalleryBaseModel : AdminBaseModel
    {
        protected readonly IGalleryService _galleryService;

        public GalleryBaseModel(IGalleryService galleryService)
        {
            _galleryService = galleryService;

        }

        public GalleryBaseModel()
        {
            _galleryService = Startup.AutofacContainer.Resolve<IGalleryService>();
        }
    }
}
