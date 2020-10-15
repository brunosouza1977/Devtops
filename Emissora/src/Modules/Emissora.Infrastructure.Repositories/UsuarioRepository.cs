using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Emissora.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private List<Usuario> usuarios;
        public UsuarioRepository()
        {
            usuarios = new List<Usuario>();
        }
        public IEnumerable<Usuario> Get()
        {
            return usuarios.ToList();
        }

        public Usuario GetById(Guid id)
        {
            return usuarios.Where(filter => filter.id == id).FirstOrDefault();
        }

        public void Insert(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
    }
}
