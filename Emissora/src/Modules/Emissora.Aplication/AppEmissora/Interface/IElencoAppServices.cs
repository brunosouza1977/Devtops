using Emissora.Aplication.AppEmissora.Input;
using Emissora.Domain.Entities;
using System.Collections.Generic;

namespace Emissora.Aplication.AppEmissora.Interface
{
     public interface IElencoAppServices
    {
        Elenco Insert(Elencoinput usuario);
        Elenco GetById(int id);
        IEnumerable<Elenco> Get();
        Elenco Delete(int id);
    }
}
