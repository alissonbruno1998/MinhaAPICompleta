using DevIO.Business.Intefaces;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIOApi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependences(this IServiceCollection services) 
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            //services.AddScoped<IProdutoRepository, ProdutoRepository>();

            return services; 
        }
    }
}
