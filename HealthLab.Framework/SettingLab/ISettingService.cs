using HealthLab.Framework.BlogLab;
using HealthLab.Framework.SettingLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.SettingLab
{
    public interface ISettingService
    {
        (IList<Setting> records, int total, int totalDisplay) GetSetting(int pageIndex, int pageSize, string searchText, string sortText);
        void CreateSetting(Setting d);
        void EditSetting(Setting s);
        Setting GetSetting(int id);
        Setting DeleteSetting(int id);
    }
}
