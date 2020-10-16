using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Entities
{
    public class Obra
    {
        public Obra(int id,
                    string nomeObra,
                    float orcamento)
        {

            Id = id;
            NomeObra = nomeObra;
            Orcamento = orcamento;

        }

        public int Id { get; private set; }
        public string NomeObra { get; private set; }
        public float Orcamento { get; private set; }

    }
}
