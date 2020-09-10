using System.Threading.Tasks;

namespace HealthLab.Data
{
    public interface ISeed
    {
        Task MigrateAsync();
        Task SeedAsync();
    }
}
