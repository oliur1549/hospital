using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.TimeLab
{
    public interface ITimeRepository : IRepository<PreferredTime, int, DatabaseContext>
    {
    }
}
