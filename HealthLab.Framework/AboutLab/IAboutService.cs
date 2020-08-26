using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AboutLab
{
    public interface IAboutService
    {
        (IList<About> records, int total, int totalDisplay) GetAbout(int pageIndex, int pageSize, string searchText, string sortText);
        void CreateAbout(About ab);
        void EditAbout(About eab);
        About GetAbout(int id);
        About DeleteSlide(int id);
    }
}
