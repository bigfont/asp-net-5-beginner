namespace App03
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Hosting;
    using Microsoft.AspNet.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.OptionsModel;
    using System.Linq;

    public class Startup
    {
        public IConfigurationRoot Config { get; set; }
        public Startup(IHostingEnvironment env)
        {
            Config = new ConfigurationBuilder().AddJsonFile("myoptions.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<MyOptions>(Config);
        }
        public void Configure(IApplicationBuilder app, 
            IOptions<MyOptions> opts)
        {
            app.Run(async (context) =>
            {
                var message = string.Join(",", opts.Value.MyObj.Select(a => a.Name));
                await context.Response.WriteAsync(message);
            });
        }
    }
}
