using HealthLab.Data;
using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.TimeLab
{
    public class PreferredTime : IEntity<int>
    {
        public int Id { get; set; }
        public string AppointmentTime { get; set; }
        public IList<Appointment> Appointments { get; set; }
    }
}
