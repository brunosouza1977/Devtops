using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emissora.Infrastructure.Ioc;
using Marraia.Notifications.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace EmissoraBackEnd.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSmartNotification();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
            });

            services.AddSwaggerGen(c => { 
                        
                c.SwaggerDoc("v1",
                    new OpenApiInfo {
                        Title = "EmissoraDevTop",
                        Version = "v1",
                        Description = "Api de Cadsatro de Atores/Atrizes",
                        Contact = new OpenApiContact
                        {
                            Name = "Vagner Santos, Bruno",
                            Url = new Uri("https://github.com/brunosouza1977/Devtops")
                        }
                    });
            });

            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "EmissoraDevTop");
            });
        }

        void RegisterServices(IServiceCollection services)
        {
            new RootBootStrapper().RootRegisterServices(services);
        }
    }
}
