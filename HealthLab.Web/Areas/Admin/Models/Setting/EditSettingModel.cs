using Autofac;
using HealthLab.Framework.SettingLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace HealthLab.Web.Areas.Admin.Models.SettingModel
{
    public class EditSettingModel : SettingBaseModel
    {
        public EditSettingModel(ISettingService settingService) : base(settingService) { }
        public EditSettingModel() : base() { }

        public int Id { get; set; }
        public string BrowserTitle { get; set; }
        public string HeaderTitle { get; set; }
        public string SmallLogo { get; set; }
        [Required]
        public IFormFile smallImageFile { get; set; }
        public string LargeLogo { get; set; }
        public IFormFile largeImageFile { get; set; }
        public string Email { get; set; }
        public string FbUrl { get; set; }
        public string Copyright { get; set; }
        public string TermsCondition { get; set; }
        public string Policy { get; set; }


        public void Edit()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            string wwwRootpath = hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(smallImageFile.FileName);
            string extension = Path.GetExtension(smallImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootpath + "/smallLogo/", fileName);

            var stream = new FileStream(path, FileMode.Create);
            smallImageFile.CopyToAsync(stream);
            //-----
            var hostingEnvironment2 = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            string wwwRootpath2 = hostingEnvironment2.WebRootPath;

            string largefileName = Path.GetFileNameWithoutExtension(largeImageFile.FileName);
            string largeImageextension = Path.GetExtension(largeImageFile.FileName);
            largefileName = largefileName + DateTime.Now.ToString("yymmssfff") + largeImageextension;
            string largeImagepath = Path.Combine(wwwRootpath2 + "/largeLogo/", largefileName);

            var largeImagestream = new FileStream(largeImagepath, FileMode.Create);
            largeImageFile.CopyToAsync(largeImagestream);

            var s = new Setting
            {
                Id=this.Id,
                BrowserTitle = this.BrowserTitle,
                HeaderTitle = this.HeaderTitle,
                SmallLogo = fileName,
                LargeLogo = largefileName,
                Email=this.Email,
                FbUrl=this.FbUrl,
                Copyright=this.Copyright,
                TermsCondition=this.TermsCondition,
                Policy=this.Policy
            };


            _settingService.EditSetting(s);
        }
        internal void Load(int id)
        {
            var setting = _settingService.GetSetting(id);

            if (setting != null)
            {
                Id = setting.Id;
                BrowserTitle = setting.BrowserTitle;
                HeaderTitle = setting.HeaderTitle;
                SmallLogo = setting.SmallLogo;
                LargeLogo = setting.LargeLogo;
                Email = setting.Email;
                FbUrl = setting.FbUrl;
                Copyright = setting.Copyright;
                TermsCondition = setting.TermsCondition;
                Policy = setting.Policy;

            }
        }
    }
}
