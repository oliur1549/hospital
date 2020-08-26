using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.ServiceLab
{
    public interface IServiceRepository : IRepository<Service,int,DatabaseContext>
    {
    }
}
