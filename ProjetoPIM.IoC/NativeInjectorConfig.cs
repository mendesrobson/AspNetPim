using Microsoft.Extensions.DependencyInjection;
using ProjetoPIM.Data.Repositories;
using ProjetoPIM.Domain.Interfaces;
using ProjetoPIM.Domain.Repositories;

namespace ProjetoPIM.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaTelefoneRepository, PessoaTelefoneRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            services.AddScoped<ITipoTelefoneRepository, TipoTelefoneRepository>();
        }
    }
}
