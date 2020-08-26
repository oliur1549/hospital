using Autofac;
using HealthLab.Framework.ServiceLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models
{
    public class ServiceBaseModel : AdminBaseModel
    {
        protected readonly IServicesService _servicesService;
        public ServiceBaseModel(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        public ServiceBaseModel()
        {
            _servicesService = Startup.AutofacContainer.Resolve<IServicesService>();
        }
    }
}
