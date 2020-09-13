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

        public Appointment DeleteAppointment(Guid id)
        {
            var Prop = _appointmentUnitOfWork.AppointmentRepository.GetById(id);
            _appointmentUnitOfWork.AppointmentRepository.Remove(Prop);
            _appointmentUnitOfWork.Save();
            return Prop;
        }


        public (IList<Appointment> records, int total, int totalDisplay) GetAppointment(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.AppointmentRepository.GetAll();
            return (result, 0, 0);
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
