using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging; // Add this using directive
using OnlineShoeStoreAPI.Services;

namespace OnlineShoeStoreAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<ShoeService>();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env, ILogger<Startup> logger) // Add ILogger parameter
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            logger.LogInformation("Configuring the HTTP request pipeline..."); // Add logging

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            logger.LogInformation("Application started and listening on port 5000"); // Add logging
        }
    }
}