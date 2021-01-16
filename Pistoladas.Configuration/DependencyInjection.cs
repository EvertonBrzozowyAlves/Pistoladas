using Microsoft.Extensions.DependencyInjection;
using Pistoladas.Business.User;
using Pistoladas.Business.User.Implementations;
using Pistoladas.Data.User;
using Pistoladas.Data.User.Implementations;

namespace Pistoladas.Configuration
{
	public static class DependencyInjection
	{
		public static void RegisterDependencies(this IServiceCollection services)
		{
			services.AddSingleton<IUserBusiness, UserBusiness>();
			services.AddSingleton<IUserData, UserDataMock>();
		}
	}
}
