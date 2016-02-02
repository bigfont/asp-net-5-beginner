using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace EmptyApplication01
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Shaun and Anthony!");
            });
        }

        public static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
    }
}
