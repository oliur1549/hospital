using Autofac;
using HealthLab.Framework.AboutLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.BlogModel
{
    public class BlogBaseModel : AdminBaseModel
    {
        protected readonly IBlogService _blogService;

        public BlogBaseModel(IBlogService blogService)
        {
            _blogService = blogService;

        }

        public BlogBaseModel()
        {
            _blogService = Startup.AutofacContainer.Resolve<IBlogService>();
        }
    }
}
