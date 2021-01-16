using Microsoft.Extensions.DependencyInjection;

namespace Pistoladas.Configuration
{
	public static class DependencyInjection
	{
		public static void RegisterDependencies(this IServiceCollection services)
		{
			//services.AddSingleton<INoteDao, NoteDaoDapper>();
		}
	}
}
