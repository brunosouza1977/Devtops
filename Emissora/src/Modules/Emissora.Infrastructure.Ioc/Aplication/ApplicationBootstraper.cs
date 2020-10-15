using Emissora.Aplication.AppEmissora;
using Emissora.Aplication.AppEmissora.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Infrastructure.Ioc.Aplication
{
    internal class ApplicationBootstraper
    {
        internal void ChildServiceRegister(IServiceCollection services)
        {
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
        }
    }
}
