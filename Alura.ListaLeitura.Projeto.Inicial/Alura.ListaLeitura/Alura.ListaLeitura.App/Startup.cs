using Alura.ListaLeitura.App.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices (IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage(); //apenas ambiente desenvolvimento.
            app.UseMvcWithDefaultRoute();
            //var builder = new RouteBuilder(app);
            //builder.MapRoute("{controller}/{action}", RoteamentoPadrao.TratamentoPadrao);
            //var rotas = builder.Build();

            //app.UseRouter(rotas);

        }
    }
}