using Emissora.Aplication.AppEmissora.Input;
using Emissora.Domain.Entities;
using System.Collections.Generic;

namespace Emissora.Aplication.AppEmissora.Interface
{
    public interface IObraAppService
    {
        Obra Insert(ObraInput usuario);
        Obra GetById(int id);
        IEnumerable<Obra> Get();
        Obra Delete(int id);
    }
}
