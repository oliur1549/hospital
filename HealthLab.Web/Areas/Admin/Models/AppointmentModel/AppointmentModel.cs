using HealthLab.Framework.AboutLab;
using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.AppointmentModel
{
    public class AppointmentModel : AppointmentBaseModel
    {
        public AppointmentModel(IAppointmentService appointmentService) : base(appointmentService) { }
        public AppointmentModel() : base() { }
        internal object GetAppointment(DataTablesAjaxRequestModel tableModel)
        {
            var data = _appointmentService.GetAppointment(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name", "Phone", "Name", "Name", "PreferredDate", "AppointmentTime" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Phone,
                                record.Department.Name,
                                record.Doctor.Name,
                                record.PreferredDate.ToString("MM/dd/yyyy"),
                                record.PreferredTime.AppointmentTime,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(Guid id)
        {
            var delete = _appointmentService.DeleteAppointment(id);
            return delete.Name;
        }
    }
}
