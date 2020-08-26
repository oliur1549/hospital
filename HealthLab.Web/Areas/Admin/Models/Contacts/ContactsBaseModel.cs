using Autofac;
using HealthLab.Framework.ContactLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.Contacts
{
    public class ContactsBaseModel : AdminBaseModel
    {
        protected readonly IContactService _contactService;
        public ContactsBaseModel(IContactService contactService)
        {
            _contactService = contactService;
        }

        public ContactsBaseModel()
        {
            _contactService = Startup.AutofacContainer.Resolve<IContactService>();
        }
    }
}
