using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AddressLab
{
    public class AddressService : IAddressService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public AddressService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateAddress(ContactInfo d)
        {
            var count = _appointmentUnitOfWork.AddressRepository.GetCount(x => x.Address == d.Address);
            if (count > 0)
                throw new DuplicationException("Image already exists", nameof(d.Address));

            _appointmentUnitOfWork.AddressRepository.Add(d);
            _appointmentUnitOfWork.Save();
        }

        public ContactInfo DeleteAddress(int id)
        {
            var aboutProp = _appointmentUnitOfWork.AddressRepository.GetById(id);
            _appointmentUnitOfWork.AddressRepository.Remove(aboutProp);
            _appointmentUnitOfWork.Save();
            return aboutProp;
        }

        public void EditAddress(ContactInfo edit)
        {
            var aboutProp = _appointmentUnitOfWork.AddressRepository.GetById(edit.Id);
            aboutProp.Id = edit.Id;
            aboutProp.Address = edit.Address;
            aboutProp.Email = edit.Email;
            aboutProp.Phone = edit.Phone;
            aboutProp.Description = edit.Description;
            aboutProp.Hotline = edit.Hotline;
            _appointmentUnitOfWork.Save();
        }

        public (IList<ContactInfo> records, int total, int totalDisplay) GetAddress(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.AddressRepository.GetAll();
            return (result, 0, 0);
        }

        public ContactInfo GetAddress(int id)
        {
            return _appointmentUnitOfWork.AddressRepository.GetById(id);
        }
    }
}
