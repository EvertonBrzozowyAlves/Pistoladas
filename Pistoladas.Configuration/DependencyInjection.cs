using Microsoft.Extensions.DependencyInjection;
using Pistoladas.Business.User;
using Pistoladas.Business.User.Implementations;
using Pistoladas.Data.Annotation;
using Pistoladas.Data.Annotation.Implementations;
using Pistoladas.Data.User;
using Pistoladas.Data.User.Implementations;

namespace Pistoladas.Configuration
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Register a concrete class for each interface in the system
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IUserBusiness, UserBusiness>();
            services.AddSingleton<IUserData, UserData>();
            services.AddSingleton<IAnnotationData, AnnotationData>();
        }
    }
}
