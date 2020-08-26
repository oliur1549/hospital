using Autofac;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.AddressLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.AddressModel
{
    public class CreateAddressModel : AddressBaseModel
    {
        public CreateAddressModel(IAddressService addressService) : base(addressService) { }
        public CreateAddressModel() : base() { }

        
        //public string Logo { get; set; }
        //public IFormFile imageLogo { get; set; }
        [Required]
        [StringLength(40)]
        [Display(Name = "Title")]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public string Hotline { get; set; }
        //[Required]
        //public string QuickLink1 { get; set; }
        //public string Field1Name { get; set; }
        //public string Field1Link { get; set; }
        //public string Field2Name { get; set; }
        //public string Field2Link { get; set; }
        //public string Field3Name { get; set; }
        //public string Field3Link { get; set; }
        //public string Field4Name { get; set; }
        //public string Field4Link { get; set; }
        //[Required]
        //public string QuickLink2 { get; set; }
        //public string Fields1Name { get; set; }
        //public string Fields1Link { get; set; }
        //public string Fields2Name { get; set; }
        //public string Fields2Link { get; set; }
        //public string Fields3Name { get; set; }
        //public string Fields3Link { get; set; }
        //public string Fields4Name { get; set; }
        //public string Fields4Link { get; set; }


        public void Create()
        {
            //var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            //string wwwRootpath = hostingEnvironment.WebRootPath;
            //string fileName = Path.GetFileNameWithoutExtension(imageLogo.FileName);
            //string extension = Path.GetExtension(imageLogo.FileName);
            //fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            //string path = Path.Combine(wwwRootpath + "/footer/", fileName);

            //var stream = new FileStream(path, FileMode.Create);
            //imageLogo.CopyToAsync(stream);

            var ab = new ContactInfo
            {
                //Logo = fileName,
                Address = this.Address,
                Email = this.Email,
                Phone=this.Phone,
                Description = this.Description,
                Hotline=this.Hotline
                //QuickLink1=this.QuickLink1,
                //Field1Name=this.Field1Name,
                //Field1Link=this.Field1Link,
                //Field2Name = this.Field2Name,
                //Field2Link = this.Field2Link,
                //Field3Name = this.Field3Name,
                //Field3Link = this.Field3Link,
                //Field4Name = this.Field4Name,
                //Field4Link = this.Field4Link,
                //QuickLink2=this.QuickLink2,
                //Fields1Name=this.Fields1Name,
                //Fields1Link=this.Fields1Link,
                //Fields2Name = this.Fields2Name,
                //Fields2Link = this.Fields2Link,
                //Fields3Name = this.Fields3Name,
                //Fields3Link = this.Fields3Link,
                //Fields4Name = this.Fields4Name,
                //Fields4Link = this.Fields4Link
            };


            _addressService.CreateAddress(ab);
        }
    }
}
