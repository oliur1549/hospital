using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.TimeLab
{
    public class TimeRepository : Repository<PreferredTime, int, DatabaseContext>, ITimeRepository
    {
        public TimeRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
