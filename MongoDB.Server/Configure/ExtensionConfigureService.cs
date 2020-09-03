using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace MongoDB.Repository.Configure
{
    public static class ExtensionConfigureService
    {
        /// <summary>
        /// injections <see cref="IMongoDBSetting"/> config and <see cref="MongoDBService"/>
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        public static void AddMongoDBRepository(this IServiceCollection services, IConfiguration config)
        {
        
            services.Configure<MongoDBSetting>(config); 
            // Configuration.GetSection(nameof(MongoDBSetting))

            services.AddSingleton<IMongoDBSetting>(sp =>
                sp.GetRequiredService<IOptions<MongoDBSetting>>().Value);
            services.AddSingleton<MongoDBService>();
        }
    }
}
