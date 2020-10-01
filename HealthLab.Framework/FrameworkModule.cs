using Autofac;
using HealthLab.Framework;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.AddressLab;
using HealthLab.Framework.AppointmentLab;
using HealthLab.Framework.BlogLab;
using HealthLab.Framework.ContactLab;
using HealthLab.Framework.DepartmentLab;
using HealthLab.Framework.DoctorLab;
using HealthLab.Framework.GalleryLab;
using HealthLab.Framework.ServiceLab;
using HealthLab.Framework.SettingLab;
using HealthLab.Framework.SlideShowLab;
using HealthLab.Framework.TimeLab;
using Membership.Data;
using Membership.Services;

namespace HealthLab.Framework
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ServiceUnitOfWork>().As<IServiceUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ServiceRepository>().As<IServiceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ServicesService>().As<IServicesService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AppointmentUnitOfWork>().As<IAppointmentUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AppointmentRepository>().As<IAppointmentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AppointmentService>().As<IAppointmentService>()
                .InstancePerLifetimeScope();
            
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DeptService>().As<IDeptService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DoctorRepository>().As<IDoctorRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TimeRepository>().As<ITimeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SlideService>().As<ISlideService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SlideRepository>().As<ISlideRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AboutRepository>().As<IAboutRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AboutService>().As<IAboutService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GalleryRepository>().As<IGalleryRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GalleryService>().As<IGalleryService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DoctorRepository>().As<IDoctorRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DoctorService>().As<IDoctorService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AddressRepository>().As<IAddressRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AddressService>().As<IAddressService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BlogRepository>().As<IBlogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BlogService>().As<IBlogService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SettingRepository>().As<ISettingRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SettingService>().As<ISettingService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ContactRepository>().As<IContactRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ContactService>().As<IContactService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AccountSeed>()
               .InstancePerLifetimeScope();

            builder.RegisterType<CurrentUserService>().As<ICurrentUserService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TimeRepository>().As<ITimeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TimeService>().As<ITimeService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
