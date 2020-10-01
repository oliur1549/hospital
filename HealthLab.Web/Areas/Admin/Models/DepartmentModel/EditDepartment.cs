using HealthLab.Framework.DepartmentLab;
using HealthLab.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.DepartmentModel
{
    public class EditDepartment : DeptBaseModel
    {
        public EditDepartment(IDeptService deptService) : base(deptService) { }
        public EditDepartment() : base() { }

        public int Id { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; }
        public void Edit()
        {
            var d = new Department
            {
                Id=this.Id,
                Name=this.Name
            };
            _deptService.EditDept(d);
        }
        internal void Load(int id)
        {
            var dept = _deptService.GetDept(id);

            if (dept != null)
            {
                Id = dept.Id;
                Name = dept.Name;

            }
        }
    }
}
