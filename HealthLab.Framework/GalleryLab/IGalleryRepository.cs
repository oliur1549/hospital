using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.GalleryLab
{
    public interface IGalleryRepository : IRepository<Gallery, int, DatabaseContext>
    {
    }
}
