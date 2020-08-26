using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DepartmentLab
{
    public class DeptService : IDeptService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork; 
        public DeptService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }

        public void CreateDept(Department dp)
        {
            _appointmentUnitOfWork.DepartmentRepository.Add(dp);
            _appointmentUnitOfWork.Save();
        }
    }
}
