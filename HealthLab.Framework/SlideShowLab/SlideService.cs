using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthLab.Framework.SlideShowLab
{
    public class SlideService : ISlideService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public SlideService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        

        public void CreateSlide(SlideShow ss)
        {
            _appointmentUnitOfWork.SlideRepository.Add(ss);
            _appointmentUnitOfWork.Save();
        }

        public SlideShow DeleteSlide(int id)
        {
            var slideProp = _appointmentUnitOfWork.SlideRepository.GetById(id);
            _appointmentUnitOfWork.SlideRepository.Remove(slideProp);
            _appointmentUnitOfWork.Save();
            return slideProp;
        }

        public void EditSlide(SlideShow ss)
        {
            var slideProp = _appointmentUnitOfWork.SlideRepository.GetById(ss.Id);
            slideProp.Id = ss.Id;
            slideProp.Name = ss.Name;
            slideProp.Title = ss.Title;
            slideProp.Description = ss.Description;
            slideProp.Status = ss.Status;
            _appointmentUnitOfWork.Save();
        }

        public (IList<SlideShow> records, int total, int totalDisplay) GetSlide(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result= _appointmentUnitOfWork.SlideRepository.GetAll();
            return (result, 0, 0);
        }

        public SlideShow GetSlide(int id)
        {
            return _appointmentUnitOfWork.SlideRepository.GetById(id);
        }
    }
}
