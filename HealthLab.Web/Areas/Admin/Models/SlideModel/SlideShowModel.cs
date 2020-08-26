using HealthLab.Framework.SlideShowLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.SlideModel
{
    public class SlideShowModel : SlideShowBaseModel
    {
        public SlideShowModel(ISlideService slideService) : base(slideService) { }
        public SlideShowModel() : base() { }
        internal object GetSlideShow(DataTablesAjaxRequestModel tableModel)
        {
            var data = _slideService.GetSlide(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name", "Title", "Description", "Status" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Title,
                                record.Description,
                                record.Status.ToString(),
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _slideService.DeleteSlide(id);
            return delete.Description;
        }
    }
}
