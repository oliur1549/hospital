using Autofac;
using HealthLab.Framework.DoctorLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.DoctorModel
{
    public class DoctorBaseModel : AdminBaseModel
    {
        protected readonly IDoctorService _doctorService;

        public DoctorBaseModel(IDoctorService doctorService)
        {
            _doctorService = doctorService;

        }

        public DoctorBaseModel()
        {
            _doctorService = Startup.AutofacContainer.Resolve<IDoctorService>();
        }
    }
}
