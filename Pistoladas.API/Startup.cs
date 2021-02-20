using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Pistoladas.Configuration;
using System;
using System.IO;

namespace Pistoladas.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", 
                    new OpenApiInfo
                    {
                        Title = "Pistoladas.API", 
                        Version = "v1",
                        Description = "Api to provide resources for the Pistoladas project",
                        Contact = new OpenApiContact()
                        {
                            Name = "Everton Brzozowy Alves",
                            Url = new Uri("https://github.com/EvertonBrzozowyAlves/")
                        }
                    });
                
                var filePath = Path.Combine(System.AppContext.BaseDirectory, "Pistoladas.API.xml");
                c.IncludeXmlComments(filePath);
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
            });
            services.RegisterDependencies();
            EnvironmentVariables.Load();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pistoladas.API"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
