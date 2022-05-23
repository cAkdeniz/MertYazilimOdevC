using MertYazilim.DataAccess.Context.Abstract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.DataAccess.Context
{
    public static class DbConnectionService
    {
        public static void DbConnection<TDatabase>(this IServiceCollection services, IConfiguration Configuration) where TDatabase: class, IDatabase, new()
        {
            services.AddScoped<IDatabase, TDatabase>();
            TDatabase database = new TDatabase();
        }
    }
}
