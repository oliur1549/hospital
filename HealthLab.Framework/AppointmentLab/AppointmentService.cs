using HealthLab.Framework.DepartmentLab;
using HealthLab.Framework.DoctorLab;
using HealthLab.Framework.TimeLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthLab.Framework.AppointmentLab
{
    public class AppointmentService : IAppointmentService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork; 
        public AppointmentService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateAppointment(Appointment CA)
        {
            _appointmentUnitOfWork.AppointmentRepository.Add(CA);
            _appointmentUnitOfWork.Save();
        }

        public IList<Department> GetDepartment()
        {
            return _appointmentUnitOfWork.DepartmentRepository.GetAll();
        }

        public IList<Doctor> GetDocotor()
        {
            return _appointmentUnitOfWork.DoctorRepository.GetAll();
        }

        public IList<PreferredTime> GetTime()
        {
            return _appointmentUnitOfWork.TimeRepository.GetAll();
        }
    }
}
