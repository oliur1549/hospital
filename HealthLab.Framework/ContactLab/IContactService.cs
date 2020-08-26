using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.ContactLab
{
    public interface IContactService
    {
        (IList<Contact> records, int total, int totalDisplay) GetContact(int pageIndex, int pageSize, string searchText, string sortText);
        void CreateContact(Contact contact);
    }
}
