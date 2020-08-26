using HealthLab.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Linq.Dynamic.Core;

namespace HealthLab.Framework.BlogLab
{
    public class BlogRepository : Repository<Blog, int, DatabaseContext>, IBlogRepository
    {
        public BlogRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
        
    }
}
