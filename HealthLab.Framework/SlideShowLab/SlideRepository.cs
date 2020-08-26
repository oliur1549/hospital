using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.SlideShowLab
{
    public class SlideRepository : Repository<SlideShow, int, DatabaseContext>, ISlideRepository
    {
        public SlideRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
