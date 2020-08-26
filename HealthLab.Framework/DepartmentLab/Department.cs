using HealthLab.Data;
using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DepartmentLab
{
    public class Department : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Appointment> Appointments { get; set; }
    }
}
