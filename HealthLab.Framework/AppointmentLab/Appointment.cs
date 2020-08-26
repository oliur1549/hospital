using HealthLab.Data;
using HealthLab.Framework.DepartmentLab;
using HealthLab.Framework.DoctorLab;
using HealthLab.Framework.TimeLab;
using System;

namespace HealthLab.Framework.AppointmentLab
{
    public class Appointment : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public DateTime PreferredDate { get; set; }
        public int TimeId { get; set; }
        public virtual PreferredTime PreferredTime { get; set; }
    }
}
