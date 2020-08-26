using Autofac;
using HealthLab.Framework.GalleryLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.GalleryModel
{
    public class CreateGalleryModel : GalleryBaseModel
    {
        public CreateGalleryModel(IGalleryService galleryService) : base(galleryService) { }
        public CreateGalleryModel() : base() { }

        [Required]
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public IFormFile imageFile { get; set; }

        public void Create()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            string wwwRootpath = hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string extension = Path.GetExtension(imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootpath + "/gallery/", fileName);

            var stream = new FileStream(path, FileMode.Create);
            imageFile.CopyToAsync(stream);

            var ga = new Gallery
            {
                Image = fileName,
                Title = this.Title
            };
            _galleryService.CreateGallery(ga);
        }
    }
}
