using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AddressLab
{
    public interface IAddressRepository : IRepository<ContactInfo, int, DatabaseContext>
    {
    }
}
