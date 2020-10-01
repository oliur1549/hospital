using HealthLab.Framework.AppointmentLab;
using HealthLab.Framework.BlogLab;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AboutLab
{
    public class BlogService : IBlogService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public BlogService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateBlog(Blog ab)
        {
            var count = _appointmentUnitOfWork.BlogRepository.GetCount(x => x.Title == ab.Title);
            if (count > 0)
                throw new DuplicationException("Image already exists", nameof(ab.Title));

            _appointmentUnitOfWork.BlogRepository.Add(ab);
            _appointmentUnitOfWork.Save();
        }

        public Blog DeleteBlog(int id)
        {
            var aboutProp = _appointmentUnitOfWork.BlogRepository.GetById(id);
            _appointmentUnitOfWork.BlogRepository.Remove(aboutProp);
            _appointmentUnitOfWork.Save();
            return aboutProp;
        }

        public void EditBlog(Blog eab)
        {
            var count = _appointmentUnitOfWork.BlogRepository.GetCount(x => x.Title == eab.Title && x.Id==eab.Id);
            if (count > 0)
                throw new DuplicationException("Title already exists", nameof(eab.Title));
            var aboutProp = _appointmentUnitOfWork.BlogRepository.GetById(eab.Id);
            aboutProp.Id = eab.Id;
            aboutProp.Title = eab.Title;
            aboutProp.Description = eab.Description;
            aboutProp.Datetime = eab.Datetime;
            _appointmentUnitOfWork.Save();
        }

        public (IList<Blog> records, int total, int totalDisplay) GetBlog(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.BlogRepository.GetAll();
            return (result, 0, 0);
        }

        public Blog GetBlog(int id)
        {
            return _appointmentUnitOfWork.BlogRepository.GetById(id);
        }
    }
}
