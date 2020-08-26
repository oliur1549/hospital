using Autofac;
using HealthLab.Framework.AppointmentLab;
using HealthLab.Web.Models.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Models
{
    public class AppointmentBaseModel : UserBaseModel
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
