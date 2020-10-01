using HealthLab.Framework.DepartmentLab;
using System.Linq;

namespace HealthLab.Web.Areas.Admin.Models.DepartmentModel
{
    public class DepartmentModel : DeptBaseModel
    {
        public DepartmentModel(IDeptService deptService) : base(deptService) { }
        public DepartmentModel() : base() { }
        internal object GetDept(DataTablesAjaxRequestModel tableModel)
        {
            var data = _deptService.GetDept(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name"}));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _deptService.DeleteDept(id);
            return delete.Name;
        }
    }
}
