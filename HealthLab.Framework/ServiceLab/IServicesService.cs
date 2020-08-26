using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.ServiceLab
{
    public interface IServicesService
    {
        (IList<Service> records,int total, int totalDisplay) GetService(int pageIndex, int pageSize, string searchText, string sortText);
        void CreateService(Service CS);
        void EditService(Service ES);
        Service GetService(int id);
        Service DeleteService(int id);
    }
}
