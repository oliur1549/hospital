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

        public Department DeleteDept(int id)
        {
            var Prop = _appointmentUnitOfWork.DepartmentRepository.GetById(id);
            _appointmentUnitOfWork.DepartmentRepository.Remove(Prop);
            _appointmentUnitOfWork.Save();
            return Prop;
        }

        public void EditDept(Department d)
        {
            //var count = _appointmentUnitOfWork.DepartmentRepository.GetCount(x => x.Name == edit.Name && x.Id == edit.Id);
            //if (count > 0)
            //    throw new DuplicationException("Name already exists", nameof(edit.Name));

            var Prop = _appointmentUnitOfWork.DepartmentRepository.GetById(d.Id);
            Prop.Id = d.Id;
            Prop.Name = d.Name;
            _appointmentUnitOfWork.Save();
        }

        public (IList<Department> records, int total, int totalDisplay) GetDept(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.DepartmentRepository.GetAll();
            return (result, 0, 0);
        }

        public Department GetDept(int id)
        {
            return _appointmentUnitOfWork.DepartmentRepository.GetById(id);
        }
    }
}
