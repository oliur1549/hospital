using HealthLab.Framework.BlogLab;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.AboutLab
{
    public interface IBlogService
    {
        (IList<Blog> records, int total, int totalDisplay) GetBlog(int pageIndex, int pageSize, string searchText, string sortText);
        void CreateBlog(Blog ab);
        void EditBlog(Blog eab);
        Blog GetBlog(int id);
        Blog DeleteBlog(int id);
    }
}
