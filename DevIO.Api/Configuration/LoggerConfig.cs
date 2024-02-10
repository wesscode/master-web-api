

namespace DevIO.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfiguration(this IServiceCollection services)
        {
            //Configuração para funcionar o Elmah.Io
            // services.AddElmahIo(o => {
            //     o.ApiKey = "API KEY";
            //     o.LogId = new Guid("LOG_ID");
            // });

            //Configuração Elmah no provider do aspnet
            // services.AddLogging(builder =>
            // {
            //     builder.AddElmahIo(o =>
            //     {
            //         o.ApiKey = "API KEY";
            //         o.LogId = new Guid("LOG_ID");
            //     });
            //     builder.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Warning);
            // });

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            //configuração Elmah
            //app.UseElmahIO();
            return app;
        }
    }
}