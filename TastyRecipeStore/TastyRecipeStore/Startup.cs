using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TastyRecipeStore.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace TastyRecipeStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRecipeRepository, EFRecipeRepository>();
            services.AddMvc();
            
            services.AddDbContext<AppDatabase>(options => options.UseSqlServer(Configuration["Data:TastyRecipeStore:ConnectionStrings"]));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(
                routes => 
                    {
                        routes.MapRoute(
                            name: "startPage",
                            template: "{controller=Home}/{action=List}/{id?}");

                    }
                );
            SeedData.AddSeeds(app);
            
        }
    }
}
