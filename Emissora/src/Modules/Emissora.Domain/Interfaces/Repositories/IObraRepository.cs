using Emissora.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Interfaces.Repositories
{
    public interface IObraRepository
    {
            int Insert(Obra obra);
            Obra GetById(int id);
            IEnumerable<Obra> Get();

    }
}
