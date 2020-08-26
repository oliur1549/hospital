using HealthLab.Framework;
using HealthLab.Framework.AddressLab;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLab.Web.FooterViewComponent
{
    [ViewComponent(Name = "ContactInfo")]
    public class FooterViewComponent : ViewComponent
    {
        private DatabaseContext db;
        public FooterViewComponent(DatabaseContext _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<ContactInfo> ContactInfo = db.Address.ToList();
            return View("Index", ContactInfo);
        }
    }
}
