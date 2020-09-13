using HealthLab.Framework.AppointmentLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.TimeLab
{
    public class TimeService : ITimeService
    {
        public IAppointmentUnitOfWork _appointmentUnitOfWork;
        public TimeService(IAppointmentUnitOfWork appointmentUnitOfWork)
        {
            _appointmentUnitOfWork = appointmentUnitOfWork;
        }

        public void CreateTime(PreferredTime d)
        {
            var count = _appointmentUnitOfWork.TimeRepository.GetCount(x => x.AppointmentTime == d.AppointmentTime);
            if (count > 0)
                throw new DuplicationException("Time already exists", nameof(d.AppointmentTime));

            _appointmentUnitOfWork.TimeRepository.Add(d);
            _appointmentUnitOfWork.Save();
        }

        public PreferredTime DeleteTime(int id)
        {
            var Prop = _appointmentUnitOfWork.TimeRepository.GetById(id);
            _appointmentUnitOfWork.TimeRepository.Remove(Prop);
            _appointmentUnitOfWork.Save();
            return Prop;
        }

        public void EditTime(PreferredTime edit)
        {
            var aboutProp = _appointmentUnitOfWork.TimeRepository.GetById(edit.Id);
            aboutProp.Id = edit.Id;
            aboutProp.AppointmentTime = edit.AppointmentTime;
            _appointmentUnitOfWork.Save();
        }

        public (IList<PreferredTime> records, int total, int totalDisplay) GetTime(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _appointmentUnitOfWork.TimeRepository.GetAll();
            return (result, 0, 0);
        }

        public PreferredTime GetTime(int id)
        {
            return _appointmentUnitOfWork.TimeRepository.GetById(id);
        }
    }
}
