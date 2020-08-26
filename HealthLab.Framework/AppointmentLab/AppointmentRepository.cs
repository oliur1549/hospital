using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AppointmentLab
{
    public class AppointmentRepository : Repository<Appointment, Guid, DatabaseContext>, IAppointmentRepository
    {
        public AppointmentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
