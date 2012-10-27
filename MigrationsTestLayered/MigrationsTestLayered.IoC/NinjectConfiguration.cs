using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace MigrationsTestLayered.IoC
{
    public class NinjectConfiguration
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<MigrationsTestLayered.Domain.IBlogRepository>()
                .To<MigrationsTestLayered.Data.EF.BlogRepository>();
        }    
    }
}
