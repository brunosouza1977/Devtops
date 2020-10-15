using Emissora.Domain.Interfaces.Repositories;
using Emissora.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Infrastructure.Ioc.Repository
{
    internal class RepositoryBootstraper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
