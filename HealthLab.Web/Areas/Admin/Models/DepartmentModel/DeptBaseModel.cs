using Autofac;
using HealthLab.Framework.DepartmentLab;
using HealthLab.Web.Models.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.DepartmentModel
{
    public class DeptBaseModel : AdminBaseModel
    {
        protected readonly IDeptService _deptService; 
        public DeptBaseModel(IDeptService deptService)
        {
            _deptService = deptService;
        }

        public DeptBaseModel()
        {
            _deptService = Startup.AutofacContainer.Resolve<IDeptService>();
        }
    }
}
