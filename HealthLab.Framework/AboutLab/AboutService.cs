using HealthLab.Framework.AppointmentLab;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AboutLab
{
    public class AboutService : IAboutService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public AboutService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateAbout(About ab)
        {
            var count = _appointmentUnitOfWork.AboutRepository.GetCount(x => x.Image == ab.Image);
            if (count > 0)
                throw new DuplicationException("Image already exists", nameof(ab.Image));

            _appointmentUnitOfWork.AboutRepository.Add(ab);
            _appointmentUnitOfWork.Save();
        }

        public About DeleteSlide(int id)
        {
            var aboutProp = _appointmentUnitOfWork.AboutRepository.GetById(id);
            _appointmentUnitOfWork.AboutRepository.Remove(aboutProp);
            _appointmentUnitOfWork.Save();
            return aboutProp;
        }

        public void EditAbout(About eab)
        {
            var aboutProp = _appointmentUnitOfWork.AboutRepository.GetById(eab.Id);
            aboutProp.Id = eab.Id;
            aboutProp.Title = eab.Title;
            aboutProp.Description = eab.Description;
            aboutProp.Image = eab.Image;
            _appointmentUnitOfWork.Save();
        }

        public (IList<About> records, int total, int totalDisplay) GetAbout(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.AboutRepository.GetAll();
            return (result, 0, 0);
        }

        public About GetAbout(int id)
        {
            return _appointmentUnitOfWork.AboutRepository.GetById(id);
        }
    }
}
