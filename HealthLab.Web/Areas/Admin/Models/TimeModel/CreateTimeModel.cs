using Autofac;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.TimeLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.TimeModel
{
    public class CreateTimeModel : TimeBaseModel
    {
        public CreateTimeModel(ITimeService timeService) : base(timeService) { }
        public CreateTimeModel() : base() { }

        [StringLength(30)]
        [Display(Name = "Appointment Time")]
        public string AppointmentTime { get; set; }


        public void Create()
        {

            var d = new PreferredTime
            {
                AppointmentTime = this.AppointmentTime
            };


            _timeService.CreateTime(d);
        }
    }
}
