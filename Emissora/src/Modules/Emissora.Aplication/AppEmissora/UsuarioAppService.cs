using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Aplication.AppEmissora
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioAppService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IEnumerable<Usuario> Get()
        {
            return _usuarioRepository.Get();
        }

        public Usuario GetById(Guid id)
        {
            return _usuarioRepository.GetById(id);
        }

        public Guid Insert(UsuarioInput input)
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
                throw new ArgumentException("Dados Obrigatórios Não foram preenchidos!");
            }

            _usuarioRepository.Insert(usuario);
            return usuario.id;
        }
    }
}
