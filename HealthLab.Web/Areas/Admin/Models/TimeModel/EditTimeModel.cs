using HealthLab.Framework.TimeLab;
using System.ComponentModel.DataAnnotations;

namespace HealthLab.Web.Areas.Admin.Models.TimeModel
{
    public class EditTimeModel : TimeBaseModel
    {
        public EditTimeModel(ITimeService timeService) : base(timeService) { }
        public EditTimeModel() : base() { }


        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Appointment Time")]
        public string AppointmentTime { get; set; }

        public void Edit()
        {


            var d = new PreferredTime
            {
                Id=this.Id,
                AppointmentTime = this.AppointmentTime
            };


            _timeService.EditTime(d);
        }
        internal void Load(int id)
        {
            var time = _timeService.GetTime(id);

            if (time != null)
            {
                Id = time.Id;
                AppointmentTime = time.AppointmentTime;

            }
        }
    }
}
