using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.GalleryLab
{
    public class GalleryRepository : Repository<Gallery, int, DatabaseContext>, IGalleryRepository
    {
        public GalleryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
