using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ProductsMVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //scoped es creado uno por cada petición.
            //transient son creados cada vez que son solicitados (para servicios lijeros)
            //singleton son creados la primera vez que son solicitados o en configure services, siempre se usa la misma instancia.
            services.AddScoped<IRepository, Repository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // agrega MVC al flujo de canalización de peticiones (Pipeline de peticiones)
            app.UseMvc
                (
                    routes =>
                    {
                        routes.MapRoute("Default", "{Controller=Product}/{action=Index}/{id?}");
                    }
                );
        }
    }
}
