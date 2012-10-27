namespace MigrationsTestLayered.Data.EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MigrationsTestLayered.Data.EF.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MigrationsTestLayered.Data.EF.BlogContext context)
        {
            context.Blogs.AddOrUpdate(b => b.BlogId,
                new MigrationsTestLayered.Domain.Blog
                {
                    BlogId = 1,
                    Name = "Great Blog",
                    Url = "http://www.greatblog.com"
                });

            context.Blogs.AddOrUpdate(b => b.BlogId,
               new MigrationsTestLayered.Domain.Blog
               {
                   BlogId = 2,
                   Name = "Brilliant Blog",
                   Url = "http://www.brilliantblog.com"
               });

            context.Blogs.AddOrUpdate(b => b.BlogId,
               new MigrationsTestLayered.Domain.Blog
               {
                   BlogId = 3,
                   Name = "Amazing Blog",
                   Url = "http://www.amazingblog.com"
               });
        }
    }
}
