using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;

namespace EmptyApplication01
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from " + env.EnvironmentName);
            });
        }
    }
}
