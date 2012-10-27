using System.Collections.Generic;
using MigrationsTestLayered.Domain;

namespace MigrationsTestLayered.Data.EF
{
    public class BlogRepository : IBlogRepository
    {
        BlogContext context = new BlogContext();

        public IEnumerable<Blog> GetAll()
        {
            return context.Blogs;
        }
    }
}
