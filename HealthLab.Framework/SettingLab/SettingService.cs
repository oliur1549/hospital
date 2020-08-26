using HealthLab.Framework.AppointmentLab;
using System.Collections.Generic;

namespace HealthLab.Framework.SettingLab
{
    public class SettingService : ISettingService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public SettingService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }
        public void CreateSetting(Setting d)
        {
            var count = _appointmentUnitOfWork.SettingRepository.GetCount(x => x.BrowserTitle == d.BrowserTitle);
            if (count > 0)
                throw new DuplicationException("Image already exists", nameof(d.BrowserTitle));

            _appointmentUnitOfWork.SettingRepository.Add(d);
            _appointmentUnitOfWork.Save();
        }

        public Setting DeleteSetting(int id)
        {
            var aboutProp = _appointmentUnitOfWork.SettingRepository.GetById(id);
            _appointmentUnitOfWork.SettingRepository.Remove(aboutProp);
            _appointmentUnitOfWork.Save();
            return aboutProp;
        }

        public void EditSetting(Setting s)
        {
            var aboutProp = _appointmentUnitOfWork.SettingRepository.GetById(s.Id);
            aboutProp.Id = s.Id;
            aboutProp.BrowserTitle = s.BrowserTitle;
            aboutProp.HeaderTitle = s.HeaderTitle;
            aboutProp.Copyright = s.Copyright;
            aboutProp.Policy = s.Policy;
            aboutProp.Email = s.Email;
            aboutProp.FbUrl = s.FbUrl;
            aboutProp.LargeLogo = s.LargeLogo;
            aboutProp.SmallLogo = s.SmallLogo;
            aboutProp.TermsCondition = s.TermsCondition;
            _appointmentUnitOfWork.Save();
        }

        public (IList<Setting> records, int total, int totalDisplay) GetSetting(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.SettingRepository.GetAll();
            return (result, 0, 0);
        }

        public Setting GetSetting(int id)
        {
            return _appointmentUnitOfWork.SettingRepository.GetById(id);
        }
    }
}
