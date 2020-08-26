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
    public class EditSlideShow : SlideShowBaseModel
    {
        
        public EditSlideShow(ISlideService slideService) : base(slideService) {  }
        public EditSlideShow() : base() { }

        public int Id { get; set; }
        [Required]
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


        public void Edit()
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


            _slideService.EditSlide(ss);
        }

        internal void Load(int id)
        {
            var slide = _slideService.GetSlide(id);

            if (slide != null)
            {
                Id = slide.Id;
                Name = slide.Name;
                Title = slide.Title;
                Description = slide.Description;
                Status = slide.Status;

            }
        }
    }
}
