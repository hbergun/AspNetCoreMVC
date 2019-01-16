using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Smile.Northwind.Business.Abstract;
using Smile.Northwind.Business.Concrete;
using Smile.Northwind.DataAccess.Abstract;
using Smile.Northwind.DataAccess.Concrete.EntityFramework;

namespace Smile.Northwind.MVCWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            // services.AddScoped<Iservice,Service>
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDAL, EFProductDAL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
            //Middleware
        {
            if (env.IsDevelopment()) //Exc Page
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvcWithDefaultRoute(); //Defualt Route
          
        }
    }
}
