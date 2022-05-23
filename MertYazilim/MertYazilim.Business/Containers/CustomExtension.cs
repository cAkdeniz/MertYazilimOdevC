using MertYazilim.Business.Abstract;
using MertYazilim.Business.Concrete;
using MertYazilim.DataAccess.Abstract;
using MertYazilim.DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.Business.Containers
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<ILogService, LogManager>();
            services.AddScoped<ILogDal, LogDal>();
        }
    }
}
