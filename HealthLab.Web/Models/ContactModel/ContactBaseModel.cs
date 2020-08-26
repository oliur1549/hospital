using Autofac;
using HealthLab.Framework.ContactLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Models.ContactModel
{
    public class ContactBaseModel
    {
        protected readonly IContactService ContactService;
        public ContactBaseModel(IContactService contactService)
        {
            ContactService = contactService;
        }

        public ContactBaseModel()
        {
            ContactService = Startup.AutofacContainer.Resolve<IContactService>();
        }
    }
}
