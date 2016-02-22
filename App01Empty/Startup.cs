using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace App01
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
    }
}
