using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using Marraia.Notifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Aplication.AppEmissora
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ISmartNotification _notification;
        public UsuarioAppService(ISmartNotification notification,
                                 IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            _notification = notification;
        }
        public IEnumerable<Usuario> Get()
        {
            return _usuarioRepository.Get();
        }

        public Usuario GetById(int id)
        {
            return _usuarioRepository.GetById(id);
        }

        public Usuario Insert(UsuarioInput input)
        {

            var usuario = new Usuario(input.Nome,
                                      input.Cpf,
                                      input.Login,
                                      input.Senha,
                                      input.TipoPerfil,
                                      input.Cache,
                                      input.GeneroObra,
                                      input.DataDisponibilidade,
                                      input.Cidade,
                                      input.Estado,
                                      input.Cep);
            if (!usuario.IsValid())
            {

                _notification.NewNotificationBadRequest("Dados Obrigatórios Não foram preenchidos!");

            }

           var id = _usuarioRepository.Insert(usuario);
            usuario.SetId(id);
            return usuario;
        }
    }
}
