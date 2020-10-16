using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Entities
{
    public class Elenco
    {
        public int Id { get; set; }
        public int Idator { get; set; }
        public int Idobra { get; set; }

        public Elenco()
        {

        }

        public Elenco(int id, int idator, int idobra)
        {
            Id = id;
            Idator = idator;
            Idobra = idobra;
        }

        public Elenco(int v1, string v2, float v3)
        {
        }
    }
}
