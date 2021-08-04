using Agenda.Domain.Contracts.ApplicationService;
using Agenda.Domain.Contracts.Repositories;
using Agenda.Infra.Context;
using Agenda.Infra.Repository;
using Agenda.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Agenda.Interface.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();

            #region Repositories
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            #endregion


            #region ApplicationServices
            services.AddScoped<IProdutoApplicationService, ProdutoApplicationService>();
            #endregion

            return services;
        }
    }
}



