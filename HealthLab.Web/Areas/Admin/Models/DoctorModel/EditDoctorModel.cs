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
    public class EditDoctorModel : DoctorBaseModel
    {
        public EditDoctorModel(IDoctorService doctorService) : base(doctorService) { }
        public EditDoctorModel() : base() { }

        public int Id { get; set; }
        [StringLength(30)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        public IFormFile imageFile { get; set; }

        [StringLength(11)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [StringLength(50)]
        [Display(Name = "Address")]
        public string Address { get; set; }


        public void Edit()
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
                Id=this.Id,
                Name = this.Name,
                Image = fileName,
                Phone = this.Phone,
                Address = this.Address
            };


            _doctorService.EditDoctor(d);
        }
        internal void Load(int id)
        {
            var doctor = _doctorService.GetDoctor(id);

            if (doctor != null)
            {
                Id = doctor.Id;
                Name = doctor.Name;
                Image = doctor.Image;
                Phone = doctor.Phone;
                Address = doctor.Address;

            }
        }
    }
}
