using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.TimeLab
{
    public interface ITimeService
    {
        void CreateTime(PreferredTime d);
        void EditTime(PreferredTime edit);
        (IList<PreferredTime> records, int total, int totalDisplay) GetTime(int pageIndex, int pageSize, string searchText, string sortText);
        PreferredTime DeleteTime(int id);
        PreferredTime GetTime(int id);
    }
}
