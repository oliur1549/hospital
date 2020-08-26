using HealthLab.Framework.AppointmentLab;
using System.Collections.Generic;

namespace HealthLab.Framework.ContactLab
{
    public class ContactService : IContactService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public ContactService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateContact(Contact contact)
        {
            _appointmentUnitOfWork.ContactRepository.Add(contact);
            _appointmentUnitOfWork.Save();
        }

        public (IList<Contact> records, int total, int totalDisplay) GetContact(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.ContactRepository.GetAll();
            return (result,0,0);
        }
    }
}
