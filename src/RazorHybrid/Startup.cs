using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RazorHybrid
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
            services.AddRazorPages();

            services.AddSingleton(new Repos.UserRepo(new List<Repos.User>
            {
                new Repos.User { Id = Guid.NewGuid(), FirstName = "John",LastName =""},
                new Repos.User { Id = Guid.Parse("9fe4b0ac-edce-4636-86c1-a8e7f49f3295"), FirstName = "Jane" ,LastName =""},
                new Repos.User { Id = Guid.Parse("9fe4b0ac-edce-4636-86c1-a8e7f49f3567"), FirstName = "Bob", LastName ="" },

            }));

            services.AddSingleton(new Repos.TodoRepo(new List<Repos.TodoItem>{
                new Repos.TodoItem{
                    Id = Guid.NewGuid(),
                    Title = "Learn ASP.NET Core",
                },
                new Repos.TodoItem{
                    Id = Guid.NewGuid(),
                    Title = "I'm assigned!",
                    AssignedUserId = Guid.Parse("9fe4b0ac-edce-4636-86c1-a8e7f49f3295"),
                },

            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
