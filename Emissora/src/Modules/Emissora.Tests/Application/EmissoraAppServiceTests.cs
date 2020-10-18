using Castle.Core.Configuration;
using Emissora.Aplication.AppEmissora;
using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using Emissora.Infrastructure.Repositories;
using FluentAssertions;
using Marraia.Notifications;
using Marraia.Notifications.Interfaces;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xunit;

namespace Emissora.Tests.Application
{
    public class EmissoraAppServiceTests
    {
        private IUsuarioRepository usuarioRepository;
        private ISmartNotification smartNotification;
        private IConfiguration configuration;
        private UsuarioAppService usuarioAppService;



        public EmissoraAppServiceTests()
        {
            usuarioRepository = Substitute.For<IUsuarioRepository>();
            smartNotification = Substitute.For<ISmartNotification>();

            usuarioRepository = new UsuarioRepository((Microsoft.Extensions.Configuration.IConfiguration)configuration);
            usuarioAppService = new UsuarioAppService(smartNotification, usuarioRepository);
                 


        }

        [Fact]
        public void Validar_retorno_get_com_sucesso()
        {
            //arrange
            var lista = new List<Usuario>();
            lista.Add(new Usuario(1, "Bruno Melo", 97524492, "bruno", "1234", 1, 200000, 1,DateTime.Today, "Recife", "PE", 53050260, DateTime.Today));
            usuarioRepository.Get().Returns(lista);

            //act
            var retorno = usuarioAppService.Get();





            //assert
            retorno.Should().HaveCount(1);

            usuarioRepository.Get().Received(1);
        }
            



    }
}
