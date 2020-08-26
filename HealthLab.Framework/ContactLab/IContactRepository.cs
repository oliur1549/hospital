using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.ContactLab
{
    public interface IContactRepository : IRepository<Contact, Guid, DatabaseContext>
    {
        
    }
}
