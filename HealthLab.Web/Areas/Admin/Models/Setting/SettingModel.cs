using HealthLab.Framework.SettingLab;
using System.Linq;

namespace HealthLab.Web.Areas.Admin.Models.SettingModel
{
    public class SettingModel : SettingBaseModel
    {
        public SettingModel(ISettingService settingService) : base(settingService) { }
        public SettingModel() : base() { }
        internal object GetSetting(DataTablesAjaxRequestModel tableModel)
        {
            var data = _settingService.GetSetting(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "BrowserTitle", "HeaderTitle", "SmallLogo", "LargeLogo" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                
                                record.BrowserTitle,
                                record.HeaderTitle,
                                record.SmallLogo,
                                record.LargeLogo,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _settingService.DeleteSetting(id);
            return delete.BrowserTitle;
        }
    }
}
