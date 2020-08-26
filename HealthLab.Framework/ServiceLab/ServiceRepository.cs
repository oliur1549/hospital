using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.ServiceLab
{
    public class ServiceRepository : Repository<Service, int,DatabaseContext>, IServiceRepository
    {
        public ServiceRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
        
    }
}
