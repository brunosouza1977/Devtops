using Emissora.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        int Insert(Usuario usuario);
        Usuario GetById(int id);
        IEnumerable<Usuario> Get();
    }
}
