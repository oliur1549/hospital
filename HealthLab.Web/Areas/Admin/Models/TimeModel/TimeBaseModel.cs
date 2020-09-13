using Autofac;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.TimeLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.TimeModel
{
    public class TimeBaseModel : AdminBaseModel
    {
        protected readonly ITimeService _timeService;

        public TimeBaseModel(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public TimeBaseModel()
        {
            _timeService = Startup.AutofacContainer.Resolve<ITimeService>();
        }
    }
}
