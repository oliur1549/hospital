using HealthLab.Framework.ContactLab;
using HealthLab.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Models.ContactModel
{
    public class ContactModel : ContactBaseModel
    {
        public ContactModel(IContactService contactService) : base(contactService) { }
        public ContactModel() : base() { }
        internal object GetContact(DataTablesAjaxRequestModel tableModel)
        {
            var data = ContactService.GetContact(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name", "Email", "Phone", "Message" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Email,
                                record.Phone,
                                record.Message,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }
    }
}
