using Emissora.Infrastructure.Ioc.Aplication;
using Emissora.Infrastructure.Ioc.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Emissora.Infrastructure.Ioc
{
    public class RootBootStrapper
    {
        public void RootRegisterServices(IServiceCollection services)
        {
            new ApplicationBootstraper().ChildServiceRegister(services);
            new RepositoryBootstraper().ChildServiceRegister(services);
        }  
    }
}
