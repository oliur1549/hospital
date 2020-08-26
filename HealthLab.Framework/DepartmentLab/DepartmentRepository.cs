using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DepartmentLab
{
    public class DepartmentRepository : Repository<Department, int, DatabaseContext>, IDepartmentRepository
    {
        public DepartmentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
