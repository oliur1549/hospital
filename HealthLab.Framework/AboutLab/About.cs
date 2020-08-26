﻿using HealthLab.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AboutLab
{
    public class About : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
