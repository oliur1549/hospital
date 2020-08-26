using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AddressLab
{
    public interface IAddressService
    {
        void CreateAddress(ContactInfo d);
        void EditAddress(ContactInfo edit);
        (IList<ContactInfo> records, int total, int totalDisplay) GetAddress(int pageIndex, int pageSize, string searchText, string sortText);
        ContactInfo DeleteAddress(int id);
        ContactInfo GetAddress(int id);
    }
}
