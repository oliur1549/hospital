using HealthLab.Data;

namespace HealthLab.Framework.DepartmentLab
{
    public interface IDepartmentRepository : IRepository<Department, int, DatabaseContext>
    {
    }
}
