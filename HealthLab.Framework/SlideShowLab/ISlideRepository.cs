using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.SlideShowLab
{
    public interface ISlideRepository  : IRepository<SlideShow, int, DatabaseContext>
    {
    }
}
