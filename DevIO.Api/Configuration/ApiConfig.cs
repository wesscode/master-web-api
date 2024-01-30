using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true; //desabilita as formas de validações autómaticas das viewmodels 
            });

            services.AddCors(options =>
            {
                options.AddPolicy("Development",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    );
            });

            return services;
        }

        public static IApplicationBuilder UseApiConfig(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseHsts(); //informa ao browser que a aplicação so aceita Https
            }

            app.UseCors("Development");
            app.UseHttpsRedirection(); //redireciona para https
            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }
    }
}