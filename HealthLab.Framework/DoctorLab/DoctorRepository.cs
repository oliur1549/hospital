using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DoctorLab
{
    public class DoctorRepository : Repository<Doctor, int, DatabaseContext>, IDoctorRepository
    {
        public DoctorRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
            
        }
    }
}
