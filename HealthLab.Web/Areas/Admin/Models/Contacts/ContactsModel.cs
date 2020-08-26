using HealthLab.Framework.ContactLab;
using System.Linq;

namespace HealthLab.Web.Areas.Admin.Models.Contacts
{
    public class ContactsModel : ContactsBaseModel
    {
        public ContactsModel(IContactService contactService) : base(contactService) { }
        public ContactsModel() : base() { }
        internal object GetContact(DataTablesAjaxRequestModel tableModel)
        {
            var data = _contactService.GetContact(
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
                                record.Message
                        }
                    ).ToArray()

            };
        }
    }
}
