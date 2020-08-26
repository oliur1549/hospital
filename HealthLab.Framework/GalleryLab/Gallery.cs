using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.GalleryLab
{
    public class Gallery : IEntity<int>
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
    }
}
