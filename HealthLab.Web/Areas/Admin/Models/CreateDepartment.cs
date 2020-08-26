using HealthLab.Framework.DepartmentLab;
using HealthLab.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models
{
    public class CreateDepartment : DeptBaseModel
    {
        public CreateDepartment(IDeptService deptService) : base(deptService) { }
        public CreateDepartment() : base() { }

        [Required]
        [Display(Name="Name")]
        public string Name { get; set; }
        public void Create()
        {
            var dp = new Department
            {
                Name=this.Name
            };
            _deptService.CreateDept(dp);
        }
    }
}
