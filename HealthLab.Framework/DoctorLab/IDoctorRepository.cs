using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DoctorLab
{
    public interface IDoctorRepository : IRepository<Doctor, int, DatabaseContext>
    {
    }
}
