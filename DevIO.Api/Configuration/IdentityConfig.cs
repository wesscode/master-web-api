using DevIO.Api.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
            .AddDefaultTokenProviders(); //habilita uso de token para recuperação de emails.

            return services;
        }
    }
}