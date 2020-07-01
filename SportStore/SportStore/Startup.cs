using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportStore.Models;



namespace SportStore
{
    public class Startup
    {
        //public property
        public IConfiguration Configuration { get; }

        //public constructor
        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //dependency Injection
            //connected types by interface, but use EFrepository
            services.AddTransient<IProductRepository, EFRepository>();
            // services.AddTransient<IProductRepository, FakeProductsRep>();
            
            
            //
            services.AddDbContext<DataB>(options => options.UseSqlServer(Configuration["Data:SportStoreProducts:ConnectionString"]));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            
            app.UseMvc(routes => 
            {

                routes.MapRoute(
                    name: "defaultSporty",
                    template: "{controller=Product}/{action=List}/{Id?}"
                    );
            });

            SeedData.EnsurePop(app);
            
            
        }
    }
}
