using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.GalleryLab
{
    public interface IGalleryService
    {
        void CreateGallery(Gallery ga);
        (IList<Gallery> records, int total, int totalDisplay) GetGallery(int pageIndex, int pageSize, string searchText, string sortText);
        void EditGallery(Gallery ga);
        Gallery GetGallery(int id);
        Gallery DeleteGallery(int id);
    }
}
