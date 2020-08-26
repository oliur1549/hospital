using HealthLab.Data;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HealthLab.Framework.BlogLab
{
    public interface IBlogRepository : IRepository<Blog, int, DatabaseContext>
    {
        
    }
}
