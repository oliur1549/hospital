using HealthLab.Framework.DoctorLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.DoctorModel
{
    public class DoctorModel : DoctorBaseModel
    {
        public DoctorModel(IDoctorService doctorService) : base(doctorService) { }
        public DoctorModel() : base() { }
        internal object GetDoctor(DataTablesAjaxRequestModel tableModel)
        {
            var data = _doctorService.GetDoctor(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name",  "Image", "Phone", "Address" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Image,
                                record.Phone,
                                record.Address,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _doctorService.DeleteDoctor(id);
            return delete.Address;
        }
    }
}
