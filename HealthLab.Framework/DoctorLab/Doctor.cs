using HealthLab.Data;
using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DoctorLab
{
    public class Doctor : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public IList<Appointment> Appointments { get; set; }
    }
}
