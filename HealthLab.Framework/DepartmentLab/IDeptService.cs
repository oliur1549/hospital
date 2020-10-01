using System.Collections.Generic;

namespace HealthLab.Framework.DepartmentLab
{
    public interface IDeptService
    {
        void CreateDept(Department dp);
        (IList<Department> records, int total, int totalDisplay) GetDept(int pageIndex, int pageSize, string searchText, string sortText);
        Department DeleteDept(int id);
        Department GetDept(int id);
        void EditDept(Department d);
    }
}
