using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DoctorLab
{
    public class DoctorService : IDoctorService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public DoctorService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateDoctor(Doctor d)
        {
            var count = _appointmentUnitOfWork.DoctorRepository.GetCount(x => x.Name == d.Name);
            if (count > 0)
                throw new DuplicationException("Image already exists", nameof(d.Name));

            _appointmentUnitOfWork.DoctorRepository.Add(d);
            _appointmentUnitOfWork.Save();
        }

        public Doctor DeleteDoctor(int id)
        {
            var aboutProp = _appointmentUnitOfWork.DoctorRepository.GetById(id);
            _appointmentUnitOfWork.DoctorRepository.Remove(aboutProp);
            _appointmentUnitOfWork.Save();
            return aboutProp;
        }

        public void EditDoctor(Doctor d)
        {
            var aboutProp = _appointmentUnitOfWork.DoctorRepository.GetById(d.Id);
            aboutProp.Id = d.Id;
            aboutProp.Name = d.Name;
            aboutProp.Image = d.Image;
            aboutProp.Phone = d.Phone;
            aboutProp.Address = d.Address;
            _appointmentUnitOfWork.Save();
        }

        public (IList<Doctor> records, int total, int totalDisplay) GetDoctor(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.DoctorRepository.GetAll();
            return (result, 0, 0);
        }

        public Doctor GetDoctor(int id)
        {
            return _appointmentUnitOfWork.DoctorRepository.GetById(id);
        }
    }
}
