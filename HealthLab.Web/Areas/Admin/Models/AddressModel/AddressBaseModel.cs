using Autofac;
using HealthLab.Framework.AboutLab;
using HealthLab.Framework.AddressLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.Areas.Admin.Models.AddressModel
{
    public class AddressBaseModel : AdminBaseModel
    {
        protected readonly IAddressService _addressService;

        public AddressBaseModel(IAddressService addressService)
        {
            _addressService = addressService;

        }

        public AddressBaseModel()
        {
            _addressService = Startup.AutofacContainer.Resolve<IAddressService>();
        }
    }
}
