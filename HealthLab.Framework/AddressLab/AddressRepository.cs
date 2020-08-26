using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AddressLab
{
    public class AddressRepository : Repository<ContactInfo, int, DatabaseContext>, IAddressRepository
    {
        public AddressRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
            
        }
    }
}
