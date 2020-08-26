using HealthLab.Data;

namespace HealthLab.Framework.SettingLab
{
    public class Setting : IEntity<int>
    {
        public int Id { get; set; }
        public string BrowserTitle { get; set; }
        public string HeaderTitle { get; set; }
        public string SmallLogo { get; set; }
        public string LargeLogo { get; set; }
        public string Email { get; set; }
        public string FbUrl { get; set; }
        public string Copyright { get; set; }
        public string TermsCondition { get; set; }
        public string Policy { get; set; }
    }
}
