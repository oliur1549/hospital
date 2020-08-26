using HealthLab.Data;

namespace HealthLab.Framework.SlideShowLab
{
    public class SlideShow : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
