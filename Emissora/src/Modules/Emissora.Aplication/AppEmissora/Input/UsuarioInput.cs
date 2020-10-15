using System;
using System.Collections.Generic;
using System.Text;

namespace Emissora.Aplication.AppEmissora.Input
{
    public class UsuarioInput
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool TipoPerfil { get; set; }
        public float Cache { get; set; }
        public int GeneroObra { get; set; }
        public DateTime DataDisponibilidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
    }
}
