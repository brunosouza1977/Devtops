using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Domain.Entities
{
    public class Obra
    {
        public Obra(int id,
                    string nomeObra,
                    int orcamento,
                    int idGenero,
                    DateTime dataInicio,
                    DateTime dataFim,
                    DateTime dataCadastro)
        {
            SetId(id);
            NomeObra = nomeObra;
            IdGenero = idGenero;
            Orcamento = orcamento;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DataCadastro = dataCadastro;

        }

        public Obra(string nomeObra,
                   int orcamento,
                   DateTime dataInicio,
                   DateTime dataFim)
        {

            NomeObra = nomeObra;
            Orcamento = orcamento;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; private set; }
        public string NomeObra { get; private set; }
        public int IdGenero { get; private set; }
        public int Orcamento { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public bool IsValid()
        {
            var validar = true;
            if (string.IsNullOrEmpty(NomeObra))
            {
                validar = false;
            }

            return validar;

        }

        public void SetId(int id)
        {
            Id = id;
        }

    }
}
