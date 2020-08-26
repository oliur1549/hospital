using Autofac;
using HealthLab.Framework.DoctorLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.DoctorModel
{
    public class CreateDoctorModel : DoctorBaseModel
    {
        public CreateDoctorModel(IDoctorService doctorService) : base(doctorService) { }
        public CreateDoctorModel() : base() { }

        [StringLength(30)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public IFormFile imageFile { get; set; }

        [StringLength(11)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [StringLength(50)]
        [Display(Name = "Address")]
        public string Address { get; set; }


        public void Create()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            string wwwRootpath = hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string extension = Path.GetExtension(imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootpath + "/doctor/", fileName);

            var stream = new FileStream(path, FileMode.Create);
            imageFile.CopyToAsync(stream);

            var d = new Doctor
            {
                Name = this.Name,
                Image = fileName,
                Phone=this.Phone,
                Address=this.Address
            };


            _doctorService.CreateDoctor(d);
        }
    }
}
