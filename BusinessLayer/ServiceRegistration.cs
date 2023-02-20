using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ServiceRegistration
    {
        public static void BusinessRegister(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IAboutService, AboutManager>();
        }
    }
}
