using Emissora.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        void Insert(Usuario usuario);
        Usuario GetById(Guid id);
        IEnumerable<Usuario> Get();
    }
}
