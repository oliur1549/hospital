using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.GalleryLab
{
    public class GalleryService : IGalleryService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public GalleryService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateGallery(Gallery ga)
        {
            var count = _appointmentUnitOfWork.GalleryRepository.GetCount(x => x.Image == ga.Image);
            if (count > 0)
                throw new DuplicationException("Image already exists", nameof(ga.Image));

            _appointmentUnitOfWork.GalleryRepository.Add(ga);
            _appointmentUnitOfWork.Save();
        }

        public Gallery DeleteGallery(int id)
        {
            var aboutProp = _appointmentUnitOfWork.GalleryRepository.GetById(id);
            _appointmentUnitOfWork.GalleryRepository.Remove(aboutProp);
            _appointmentUnitOfWork.Save();
            return aboutProp;
        }

        public void EditGallery(Gallery ga)
        {
            var aboutProp = _appointmentUnitOfWork.GalleryRepository.GetById(ga.Id);
            aboutProp.Id = ga.Id;
            aboutProp.Image = ga.Image;
            aboutProp.Title = ga.Title;
            _appointmentUnitOfWork.Save();
        }

        public (IList<Gallery> records, int total, int totalDisplay) GetGallery(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.GalleryRepository.GetAll();
            return (result, 0, 0);
        }

        public Gallery GetGallery(int id)
        {
            return _appointmentUnitOfWork.GalleryRepository.GetById(id);
        }
    }
}
