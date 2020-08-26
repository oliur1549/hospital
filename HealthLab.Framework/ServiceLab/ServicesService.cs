using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthLab.Framework.ServiceLab
{
    public class ServicesService : IServicesService
    {
        public IServiceUnitOfWork _serviceUnitOfWork;
        public ServicesService(IServiceUnitOfWork serviceUnitOfWork)
        {
            _serviceUnitOfWork = serviceUnitOfWork;
        }

        public void CreateService(Service CS)
        {
            _serviceUnitOfWork.ServiceRepository.Add(CS);
            _serviceUnitOfWork.Save();
        }

        public Service DeleteService(int id)
        {
            var result = _serviceUnitOfWork.ServiceRepository.GetById(id);
            _serviceUnitOfWork.ServiceRepository.Remove(result);
            _serviceUnitOfWork.Save();
            return result;
        }

        public void EditService(Service ES)
        {
            var result=_serviceUnitOfWork.ServiceRepository.GetById(ES.Id);
            result.ServiceName = ES.ServiceName;
            result.Description = ES.Description;
            _serviceUnitOfWork.Save();
        }

        public (IList<Service> records, int total, int totalDisplay) GetService(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result= _serviceUnitOfWork.ServiceRepository.GetAll().ToList();
            return (result, 0, 0);
        }

        public Service GetService(int id)
        {
            return _serviceUnitOfWork.ServiceRepository.GetById(id);
        }
    }
}
