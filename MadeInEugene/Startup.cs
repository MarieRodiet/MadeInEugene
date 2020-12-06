using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MadeInEugene.Models;
using MadeInEugene.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MadeInEugene
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
            services.AddControllersWithViews();
            services.AddTransient<IProductRepository, ProductRepository>();
            //comment out the if statement when you want to deploy the db to azure
            //azure can't use the sqlite migration, so we force it to use sqlserver with the
            //connection string provided on the azure database website
            /*if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                //Assuming that SQL Server is installed on Windows*/
                services.AddDbContext<ProductsCompaniesDbContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:AzureSQLServerConnection"]));
            /*

            }
            
            else
            {
                services.AddDbContext<ProductsCompaniesDbContext>(options =>
                    options.UseSqlite(Configuration["ConnectionStrings:SQLiteConnection"]));
            }*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ProductsCompaniesDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //TODO:Call the seed method
            //need to add context as a parameter to line 52
            //this is a static method
            //SeedData is a class, and the dot is calling the method Seed within that class
            SeedData.Seed(context);
        }
    }
}
