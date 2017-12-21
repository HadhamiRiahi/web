using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using web.Models;

namespace web
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IHostingEnvironment env)
        {
          
             var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

               public void ConfigureServices(IServiceCollection services)
        {   
            services.AddAutoMapper();
            services.AddDbContext<VegaDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddMvc();
             services.AddCors(options =>
    {
        options.AddPolicy("AllowSpecificOrigin",
            builder =>
            { builder.WithOrigins("*")
            .AllowAnyHeader().AllowAnyMethod();});
    }); 
        }




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.Use(async (context, next) => {
   await next();
   if (context.Response.StatusCode == 404 &&
      !Path.HasExtension(context.Request.Path.Value) &&
      !context.Request.Path.Value.StartsWith("/api/")) {
         context.Request.Path = "/index.html";
         await next();
      }
});
app.UseMvcWithDefaultRoute();
app.UseDefaultFiles();
 app.UseCors("AllowSpecificOrigin");   
         

} 
    }
}