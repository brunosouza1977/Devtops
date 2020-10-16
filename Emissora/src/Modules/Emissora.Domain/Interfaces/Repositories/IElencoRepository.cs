using Emissora.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Interfaces.Repositories
{
    public interface IElencoRepository
    {
        int Insert(Elenco elenco);
        Elenco GetById(int id);
        IEnumerable<Elenco> Get();

    }
}
