using HealthLab.Framework.ContactLab;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Models.ContactModel
{
    public class CreateContact : ContactBaseModel
    {
        public CreateContact(IContactService contactService) : base(contactService) { }
        public CreateContact() : base() { }

        [Required]
        [StringLength(20)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(14)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required]
        [StringLength(500)]
        [Display(Name = "Message")]
        public string Message { get; set; }
        

        public void Create()
        {
            var contact = new Contact
            {
                Name = this.Name,
                Email=this.Email,
                Phone = this.Phone,
                Message=this.Message
            };
            ContactService.CreateContact(contact);
        }
    }
}
