using Autofac;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.BlogLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.BlogModel
{
    public class EditBlogModel : BlogBaseModel
    {
        public EditBlogModel(IBlogService blogService) : base(blogService) { }
        public EditBlogModel() : base() { }

        public int Id { get; set; }
        [StringLength(20)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        public DateTime Datetime { get; set; }
        public string Image { get; set; }
        [Required]
        public IFormFile imageFile { get; set; }

        public void Edit()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();
            string wwwRootpath = hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string extension = Path.GetExtension(imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootpath + "/blog/", fileName);

            var stream = new FileStream(path, FileMode.Create);
            imageFile.CopyToAsync(stream);

            var eab = new Blog
            {
                Id=this.Id,
                Title = this.Title,
                Description = this.Description,
                Datetime=this.Datetime,
                Image = fileName
            };
            _blogService.EditBlog(eab);
        }
        internal void Load(int id)
        {
            var Blog = _blogService.GetBlog(id);

            if (Blog != null)
            {
                Id = Blog.Id;
                Title = Blog.Title;
                Description = Blog.Description;
                Datetime = Blog.Datetime;
                Image = Blog.Image;

            }
        }
    }
}
