using HealthLab.Framework.AboutLab;
using HealthLab.Framework.TimeLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.TimeModel
{
    public class TimeModel : TimeBaseModel
    {
        public TimeModel(ITimeService timeService) : base(timeService) { }
        public TimeModel() : base() { }
        internal object GetTime(DataTablesAjaxRequestModel tableModel)
        {
            var data = _timeService.GetTime(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "AppointmentTime"}));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.AppointmentTime,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _timeService.DeleteTime(id);
            return delete.AppointmentTime;
        }
    }
}
