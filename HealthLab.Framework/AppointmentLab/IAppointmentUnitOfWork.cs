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
    public interface IAppointmentUnitOfWork : IUnitOfWork
    {
        IAppointmentRepository AppointmentRepository { get; set; }
        IDepartmentRepository DepartmentRepository { get; set; }
        IDoctorRepository DoctorRepository { get; set; }
        ITimeRepository TimeRepository { get; set; }
        ISlideRepository SlideRepository { get; set; }
        IAboutRepository AboutRepository { get; set; }
        IGalleryRepository GalleryRepository { get; set; }
        IAddressRepository AddressRepository { get; set; }
        IBlogRepository BlogRepository { get; set; }
        ISettingRepository SettingRepository { get; set; }
        IContactRepository ContactRepository { get; set; }

    }
}
