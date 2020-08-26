using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AppointmentLab
{
    public interface IAppointmentRepository : IRepository<Appointment, Guid, DatabaseContext>
    {
    }
}
