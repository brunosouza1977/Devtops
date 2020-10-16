using Emissora.Aplication.AppEmissora.Input;
using Emissora.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Emissora.Aplication.AppEmissora.Interface
{
    public interface IUsuarioAppService
    {
        Usuario Insert(UsuarioInput usuario);
        Usuario GetById(int id);
        IEnumerable<Usuario> Get();
        Usuario Delete(int id);
    }
}
