using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Entities
{
    public class Elenco
    {
        public Elenco(int id,
                      int idator,
                      int idobra)
        {
            Id = id;
            Idator = idator;
            Idobra = idobra;
        }
        public int Id { get; private set; }
        public int Idator { get; private set; }
        public int Idobra { get; private set; }

    }
}
