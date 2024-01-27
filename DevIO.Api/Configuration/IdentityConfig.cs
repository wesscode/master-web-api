using System.Text;
using DevIO.Api.Data;
using DevIO.Api.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DevIO.Api.Configuration
{
    /*Identity ultiliza um contexto separado da aplicação, a melhor usabilidade é não misturar os contextos.*/
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            //configuração do contexto do identity, do pacote Identity.EntityFrameworkCore
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //configurando o identity do pacote Identity.UI
            services.AddDefaultIdentity<IdentityUser>() //classe de user que pode ser customizavel
            .AddRoles<IdentityRole>() //habilita uso de Roles com a classe pra roles
            .AddEntityFrameworkStores<ApplicationDbContext>() //indica o contexto
            .AddErrorDescriber<IdentityMensagensPortugues>()
            .AddDefaultTokenProviders(); //habilita uso de token para recuperação de emails.

            // JWT
            var appSettingsSection = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);


            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; //padrão de auth
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; //como resolver pra validar o token
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true; //garantia que so pode trabalhar com https
                x.SaveToken = true; //salva o token internamente, melhorando para validações posteriores.
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true, //
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = appSettings.ValidoEm,
                    ValidIssuer = appSettings.Emissor
                };
            });

            return services;
        }
    }
}