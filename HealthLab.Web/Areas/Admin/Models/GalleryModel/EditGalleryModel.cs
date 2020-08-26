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
    public class EditGalleryModel : GalleryBaseModel
    {
        public EditGalleryModel(IGalleryService galleryService) : base(galleryService) { }
        public EditGalleryModel() : base() { }

        public int Id { get; set; }
        [Required]
        public string Image { get; set; }

        public IFormFile imageFile { get; set; }
        public string Title { get; set; }

        public void Edit()
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


            _galleryService.EditGallery(ga);
        }

        internal void Load(int id)
        {
            var gallery = _galleryService.GetGallery(id);

            if (gallery != null)
            {
                Id = gallery.Id;
                Image = gallery.Image;
                Title = gallery.Title;

            }
        }
    }
}
