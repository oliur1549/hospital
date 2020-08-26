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
    public class EditAddressModel : AddressBaseModel
    {
        public EditAddressModel(IAddressService addressService) : base(addressService) { }
        public EditAddressModel() : base() { }

        public int Id { get; set; }
        [StringLength(40)]
        [Display(Name = "Title")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Description { get; set; }
        public string Hotline { get; set; }

        public void Edit()
        {
            

            var edit = new ContactInfo
            {
                Id=this.Id,
                Address = this.Address,
                Email = this.Email,
                Phone = this.Phone,
                Description = this.Description,
                Hotline = this.Hotline
            };
            _addressService.EditAddress(edit);
        }
        internal void Load(int id)
        {
            var a = _addressService.GetAddress(id);

            if (a != null)
            {
                Id = a.Id;
                Address = a.Address;
                Email = a.Email;
                Phone = a.Phone;
                Description = a.Description;
                Hotline = a.Hotline;

            }
        }
    }
}
