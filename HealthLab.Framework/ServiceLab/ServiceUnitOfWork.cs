using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.ServiceLab
{
    public class ServiceUnitOfWork : UnitOfWork, IServiceUnitOfWork
    {
        public IServiceRepository ServiceRepository { get; set; }
        public ServiceUnitOfWork(DatabaseContext databaseContext, IServiceRepository serviceRepository)
            :base(databaseContext)
        {
            ServiceRepository = serviceRepository;
        }
    }
}
