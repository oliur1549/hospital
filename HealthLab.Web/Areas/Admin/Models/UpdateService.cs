using HealthLab.Framework.ServiceLab;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models
{
    public class UpdateService : ServiceBaseModel
    {
        public UpdateService(IServicesService servicesService) : base(servicesService) { }
        public UpdateService() : base() { }
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public void Edit()
        {
            var ES = new Service
            {
                Id=this.Id,
                ServiceName=this.ServiceName,
                Description=this.Description
            };
            _servicesService.EditService(ES);
        }

        internal void Load(int id)
        {
            var result = _servicesService.GetService(id);
            
            if(result != null)
            {
                Id = result.Id;
                ServiceName = result.ServiceName;
                Description = result.Description;
            }
        }
    }
}
