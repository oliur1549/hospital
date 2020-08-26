using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.ContactLab
{
    public class ContactRepository : Repository<Contact, Guid, DatabaseContext>, IContactRepository
    {
        public ContactRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
