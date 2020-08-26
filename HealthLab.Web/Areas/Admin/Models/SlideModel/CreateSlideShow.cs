using Autofac;
using HealthLab.Framework.SlideShowLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace HealthLab.Web.Areas.Admin.Models.SlideModel
{
    public class CreateSlideShow : SlideShowBaseModel
    {
        
        public CreateSlideShow(ISlideService slideService) : base(slideService) {  }
        public CreateSlideShow() : base() { }

        
        [Display(Name = "Service Name")]
        public string Name { get; set; }

        
        [StringLength(20)]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        public IFormFile imageFile { get; set; }

        
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        
        public bool Status { get; set; }


        public void Create()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            string wwwRootpath = hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string extension = Path.GetExtension(imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootpath + "/slideshow/", fileName);

            var stream = new FileStream(path, FileMode.Create);
            imageFile.CopyToAsync(stream);

            var ss = new SlideShow
            {
                Name = fileName,
                Title = this.Title,
                Description = this.Description,
                Status = this.Status
            };


            _slideService.CreateSlide(ss);
        }
    }
}
