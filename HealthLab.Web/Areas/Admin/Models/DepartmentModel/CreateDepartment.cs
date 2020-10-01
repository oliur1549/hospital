using HealthLab.Framework.DepartmentLab;
using System.ComponentModel.DataAnnotations;

namespace HealthLab.Web.Areas.Admin.Models.DepartmentModel
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
