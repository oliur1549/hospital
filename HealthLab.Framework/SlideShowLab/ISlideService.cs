using System.Collections;
using System.Collections.Generic;

namespace HealthLab.Framework.SlideShowLab
{
    public interface ISlideService
    {
        //void CreateSlide(SlideShow slide);
        (IList<SlideShow> records, int total, int totalDisplay) GetSlide(int pageIndex, int pageSize, string searchText, string sortText);
        //void CreateSlide(object slide);
        void CreateSlide(SlideShow ss);
        SlideShow GetSlide(int id);
        void EditSlide(SlideShow ss);
        SlideShow DeleteSlide(int id);
    }
}
