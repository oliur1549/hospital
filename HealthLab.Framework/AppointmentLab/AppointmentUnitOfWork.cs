using HealthLab.Data;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.AddressLab;
using HealthLab.Framework.BlogLab;
using HealthLab.Framework.ContactLab;
using HealthLab.Framework.DepartmentLab;
using HealthLab.Framework.DoctorLab;
using HealthLab.Framework.GalleryLab;
using HealthLab.Framework.SettingLab;
using HealthLab.Framework.SlideShowLab;
using HealthLab.Framework.TimeLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AppointmentLab
{
    public class AppointmentUnitOfWork : UnitOfWork, IAppointmentUnitOfWork
    {
        public IAppointmentRepository AppointmentRepository { get ; set ; }
        public IDepartmentRepository DepartmentRepository { get; set ; }
        public IDoctorRepository DoctorRepository { get ; set; }
        public ITimeRepository TimeRepository { get; set ; }
        public ISlideRepository SlideRepository { get; set; }
        public IAboutRepository AboutRepository { get; set; }
        public IGalleryRepository GalleryRepository { get; set; }
        public IAddressRepository AddressRepository { get; set; }
        public IBlogRepository BlogRepository { get ; set ; }
        public ISettingRepository SettingRepository { get; set; }
        public IContactRepository ContactRepository { get; set; }

        public AppointmentUnitOfWork(DatabaseContext databaseContext, 
            IAppointmentRepository appointmentRepository,
            IDepartmentRepository departmentRepository,
            IDoctorRepository doctorRepository,
            ITimeRepository timeRepository, 
            ISlideRepository slideRepository,
            IAboutRepository aboutRepository,
            IGalleryRepository galleryRepository,
            IAddressRepository addressRepository,
            IBlogRepository blogRepository,
            ISettingRepository settingRepository,
            IContactRepository contactRepository)
            : base(databaseContext)
        {
            AppointmentRepository = appointmentRepository;
            DepartmentRepository = departmentRepository;
            DoctorRepository = doctorRepository;
            TimeRepository = timeRepository;
            SlideRepository = slideRepository;
            AboutRepository = aboutRepository;
            GalleryRepository = galleryRepository;
            AddressRepository = addressRepository;
            BlogRepository = blogRepository;
            SettingRepository = settingRepository;
            ContactRepository = contactRepository;
        }
    }
}
