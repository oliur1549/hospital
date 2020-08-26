using HealthLab.Data;
using HealthLab.Framework.SettingLab;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HealthLab.Framework.SettingLab
{
    public interface ISettingRepository : IRepository<Setting, int, DatabaseContext>
    {
        
    }
}
