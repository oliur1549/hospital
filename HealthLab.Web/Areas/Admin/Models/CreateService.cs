using HealthLab.Framework.ServiceLab;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models
{
    public class CreateService : ServiceBaseModel
    {
        public CreateService(IServicesService servicesService) : base(servicesService) { }
        public CreateService() : base() { }

        [Required]
        [StringLength(20)]
        [Display(Name="Service Name")]
        public string ServiceName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public void Create()
        {
            var CS = new Service
            {
                ServiceName=this.ServiceName,
                Description=this.Description
            };
            _servicesService.CreateService(CS);
        }
    }
}
