using System.Collections.Generic;

namespace MigrationsTestLayered.Domain
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAll();
    }
}
