using HealthLab.Data;
using HealthLab.Framework.SettingLab;

namespace HealthLab.Framework.SettingLab
{
    public class SettingRepository : Repository<Setting, int, DatabaseContext>, ISettingRepository
    {
        public SettingRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
        
    }
}
