namespace App02
{
    using Microsoft.AspNet.Mvc;
    using Microsoft.Extensions.Logging;
    public class MyController : Controller
    {
        public MyController(ILogger logger)
        {
            logger.LogInformation("Logging from my controller");
        }
    }
}

namespace App02
{
    using Microsoft.Extensions.Logging;
    public class MyLoggingProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new MyLogger();
        }

        public void Dispose()
        {
            // TODO Cleanup   
        }
    }
}

namespace App02
{
    using System;
    using System.IO;
    using System.Text;
    using Microsoft.Extensions.Logging;

    public class MyLogger : ILogger
    {
            public void Log(LogLevel logLevel, int eventId, object state,
                Exception exception, Func<object, Exception, string> formatter)
            {
                var builder = new StringBuilder();
                if (formatter != null)
                {
                    builder.AppendLine(formatter(state, exception));
                }

                var values = state as ILogValues;
                if (values != null)
                {
                    foreach (var v in values.GetValues())
                    {
                        builder.AppendLine(v.Key + ":" + v.Value);
                    }
                }

                var logPath = string.Format("C:/temp/{0}.txt", Guid.NewGuid());
                File.WriteAllText(logPath, builder.ToString());
            }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScopeImpl(object state)
        {
            return null;
        }
    }
}

namespace App02
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;
    using Microsoft.Extensions.Logging;

    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory
                .AddConsole(minLevel: LogLevel.Verbose)
                .AddProvider(new MyLoggingProvider());

            app.Run(async (context) =>
            {
                var logger = loggerFactory.CreateLogger("CatchAll");
                logger.LogInformation("Logging from startup.cs");

                await context.Response.WriteAsync("Hello world!");
            });
        }
    }
}
