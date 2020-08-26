using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.DoctorLab
{
    public interface IDoctorService
    {
        void CreateDoctor(Doctor d);
        void EditDoctor(Doctor d);
        (IList<Doctor> records, int total, int totalDisplay) GetDoctor(int pageIndex, int pageSize, string searchText, string sortText);
        Doctor DeleteDoctor(int id);
        Doctor GetDoctor(int id);
    }
}
