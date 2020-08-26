using Autofac;
using HealthLab.Framework.SettingLab;

namespace HealthLab.Web.Areas.Admin.Models.SettingModel
{
    public class SettingBaseModel : AdminBaseModel
    {
        protected readonly ISettingService _settingService;

        public SettingBaseModel(ISettingService settingService)
        {
            _settingService = settingService;
        }

        public SettingBaseModel()
        {
            _settingService = Startup.AutofacContainer.Resolve<ISettingService>();
        }
    }
}
