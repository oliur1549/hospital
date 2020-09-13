using HealthLab.Framework.DepartmentLab;
using HealthLab.Framework.DoctorLab;
using HealthLab.Framework.TimeLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AppointmentLab
{
    public interface IAppointmentService
    {
        void CreateAppointment(Appointment cA);
        IList<Department> GetDepartment();
        IList<Doctor> GetDocotor();
        IList<PreferredTime> GetTime();
        (IList<Appointment> records, int total, int totalDisplay) GetAppointment(int pageIndex, int pageSize, string searchText, string sortText);
        Appointment DeleteAppointment(Guid id);
    }
}
