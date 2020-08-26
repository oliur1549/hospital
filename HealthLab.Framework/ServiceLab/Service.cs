using HealthLab.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace HealthLab.Framework.ServiceLab
{
    public class Service : IEntity<int>
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
    }
}
