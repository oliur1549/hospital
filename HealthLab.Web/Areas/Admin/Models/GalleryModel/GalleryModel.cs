using HealthLab.Framework.GalleryLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.GalleryModel
{
    public class GalleryModel : GalleryBaseModel
    {
        public GalleryModel(IGalleryService galleryService) : base(galleryService) { }
        public GalleryModel() : base() { }
        internal object GetGallery(DataTablesAjaxRequestModel tableModel)
        {
            var data = _galleryService.GetGallery(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name",  "Image" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Image,
                                record.Title,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _galleryService.DeleteGallery(id);
            return delete.Title;
        }
    }
}
