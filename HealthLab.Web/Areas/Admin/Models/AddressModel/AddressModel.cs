using HealthLab.Framework.AddressLab;
using System.Linq;

namespace HealthLab.Web.Areas.Admin.Models.AddressModel
{
    public class AddressModel : AddressBaseModel
    {
        public AddressModel(IAddressService addressService) : base(addressService) { }
        public AddressModel() : base() { }
        internal object GetAddress(DataTablesAjaxRequestModel tableModel)
        {
            var data = _addressService.GetAddress(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Address", "Email", "Phone", "Description", "Hotline" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Address,
                                record.Email,
                                record.Phone,
                                record.Description,
                                record.Hotline,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal string Remove(int id)
        {
            var delete = _addressService.DeleteAddress(id);
            return delete.Address;
        }
    }
}
