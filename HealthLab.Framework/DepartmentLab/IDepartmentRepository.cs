using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DepartmentLab
{
    public interface IDepartmentRepository : IRepository<Department, int, DatabaseContext>
    {
    }
}
