using Autofac;
using HealthLab.Web.Areas.Admin.Models;
using HealthLab.Web.Areas.Admin.Models.AboutModel;
using HealthLab.Web.Areas.Admin.Models.AddressModel;
using HealthLab.Web.Areas.Admin.Models.AppointmentModel;
using HealthLab.Web.Areas.Admin.Models.BlogModel;
using HealthLab.Web.Areas.Admin.Models.Contacts;
using HealthLab.Web.Areas.Admin.Models.DoctorModel;
using HealthLab.Web.Areas.Admin.Models.GalleryModel;
using HealthLab.Web.Areas.Admin.Models.SettingModel;
using HealthLab.Web.Areas.Admin.Models.SlideModel;

namespace HealthLab.Web
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ServiceModel>();
            builder.RegisterType<SlideShowModel>();
            builder.RegisterType<AboutModel>();
            builder.RegisterType<GalleryModel>();
            builder.RegisterType<DoctorModel>();
            builder.RegisterType<AddressModel>();
            builder.RegisterType<BlogModel>();
            builder.RegisterType<SettingModel>();
            builder.RegisterType<ContactsModel>();
            builder.RegisterType<AppointmentModel>();
            base.Load(builder);
        }
    }
}

