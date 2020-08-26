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
    public class CreateBlogModel : BlogBaseModel
    {
        public CreateBlogModel(IBlogService blogService) : base(blogService) { }
        public CreateBlogModel() : base() { }

        [StringLength(20)]
        [Display(Name = "Title")]
        public string Title { get; set; }


        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        public DateTime Datetime { get; set; }

        public string Image { get; set; }
        [Required]
        public IFormFile imageFile { get; set; }

        public void Create()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            string wwwRootpath = hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string extension = Path.GetExtension(imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootpath + "/blog/", fileName);

            var stream = new FileStream(path, FileMode.Create);
            imageFile.CopyToAsync(stream);

            var b = new Blog
            {
                Title = this.Title,
                Description = this.Description,
                Datetime=this.Datetime,
                Image = fileName
            };


            _blogService.CreateBlog(b);
        }
    }
}
