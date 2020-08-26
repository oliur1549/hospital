using HealthLab.Framework.ServiceLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models
{
    public class ServiceModel : ServiceBaseModel
    {
        public ServiceModel(IServicesService servicesService) : base(servicesService) { }
        public ServiceModel() : base() { }
        internal object GetExpense(DataTablesAjaxRequestModel tableModel)
        {
            var data = _servicesService.GetService(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "ServiceName", "Description" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.ServiceName,
                                record.Description,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
           var delete= _servicesService.DeleteService(id);
            return delete.Description;
        }
    }
}
