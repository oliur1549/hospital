using HealthLab.Framework.AboutLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.BlogModel
{
    public class BlogModel : BlogBaseModel
    {
        public BlogModel(IBlogService blogService) : base(blogService) { }
        public BlogModel() : base() { }
        internal object GetBlog(DataTablesAjaxRequestModel tableModel)
        {
            var data = _blogService.GetBlog(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "Description","Datetime", "Image" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Title,
                                record.Description,
                                record.Datetime.ToString("dd/mm/yyyy"),
                                record.Image,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _blogService.DeleteBlog(id);
            return delete.Description;
        }
    }
}
