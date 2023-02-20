using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer
{
    public static class  ServiceRegistrotion
    {
        public static void DataAccessLayerRegister(this IServiceCollection services)
        {
            //services.AddScoped<ICategoryDal, CategoryRepository>();
            //services.AddScoped<IBlogRepository, BlogRepository>();
        }
    }
}
