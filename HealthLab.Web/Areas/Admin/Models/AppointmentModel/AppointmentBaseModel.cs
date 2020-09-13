using Autofac;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.AppointmentModel
{
    public class AppointmentBaseModel : AdminBaseModel
    {
        protected readonly IAppointmentService _appointmentService;

        public AppointmentBaseModel(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public AppointmentBaseModel()
        {
            _appointmentService = Startup.AutofacContainer.Resolve<IAppointmentService>();
        }
    }
}
