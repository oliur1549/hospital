using HealthLab.Framework.AppointmentLab;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Models
{
    public class CreateAppointment : AppointmentBaseModel
    {
        public CreateAppointment(IAppointmentService appointmentService) : base(appointmentService) { }
        public CreateAppointment() : base() { }

        [Required]
        [StringLength(20)]
        [Display(Name="Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(14)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Required]
        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }
        [Required]
        [Display(Name = "Preferred Date")]
        public DateTime PreferredDate { get; set; }
        [Required]
        [Display(Name = "Preferred Time")]
        public int TimeId { get; set; }

        public void Create()
        {
            var CA = new Appointment
            {
                Name=this.Name,
                Phone=this.Phone,
                DepartmentId=this.DepartmentId,
                DoctorId=this.DoctorId,
                PreferredDate=this.PreferredDate,
                TimeId=this.TimeId
            };
            _appointmentService.CreateAppointment(CA);
        }
        public IList<SelectListItem> GetDepartmentList()
        {
            IList<SelectListItem> listItems = new List<SelectListItem>();

            foreach (var item in _appointmentService.GetDepartment())
            {
                var ctg = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                };
                listItems.Add(ctg);
            }
            return listItems;
        }
        public IList<SelectListItem> GetDoctorList()
        {
            IList<SelectListItem> listItems = new List<SelectListItem>();

            foreach (var item in _appointmentService.GetDocotor())
            {
                var ctg = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                };
                listItems.Add(ctg);
            }
            return listItems;
        }
        public IList<SelectListItem> GetTimeList()
        {
            IList<SelectListItem> listItems = new List<SelectListItem>();

            foreach (var item in _appointmentService.GetTime())
            {
                var ctg = new SelectListItem
                {
                    Text = item.AppointmentTime,
                    Value = item.Id.ToString()
                };
                listItems.Add(ctg);
            }
            return listItems;
        }
    }
}
