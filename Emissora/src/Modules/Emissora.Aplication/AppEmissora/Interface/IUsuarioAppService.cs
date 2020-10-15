using Emissora.Aplication.AppEmissora.Input;
using Emissora.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Emissora.Aplication.AppEmissora.Interface
{
    public interface IUsuarioAppService
    {
        Guid Insert(UsuarioInput usuario);
        Usuario GetById(Guid id);
        IEnumerable<Usuario> Get();
    }
}
