using System;
using System.Security.Cryptography.X509Certificates;

namespace Emissora.Domain.Entities
{
    public class Usuario
    {
        public Usuario(
                      int id,
                      string nome,
                      int cpf,
                      string login,
                      string senha,
                      int tipoPerfil,
                      float cache,
                      int generoObra,
                      DateTime dataDisponibilidade,
                      string cidade,
                      string estado,
                      int cep,
                      DateTime datacadastro)
        {
            SetId(id);
            Nome = nome;
            Cpf = cpf;
            Login = login;
            Senha = senha;
            TipoPerfil = tipoPerfil;
            Cache = cache;
            GeneroObra = generoObra;
            DataDisponibilidade = dataDisponibilidade;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            DataCadastro = datacadastro;
        }
        public Usuario(string nome,
                       int cpf,
                       string login,
                       string senha,
                       int tipoPerfil,
                       float cache,
                       int generoObra,
                       DateTime dataDisponibilidade,
                       string cidade,
                       string estado,
                       int cep)
        {
            Nome = nome;
            Cpf = cpf;
            Login = login;
            Senha = senha;
            TipoPerfil = tipoPerfil;
            Cache = cache;
            GeneroObra = generoObra;
            DataDisponibilidade = dataDisponibilidade;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Cpf { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public int TipoPerfil { get; private set; }
        public float Cache { get; private set; }
        public int GeneroObra { get; private set; }
        public DateTime DataDisponibilidade { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public int Cep { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public bool IsValid()
        {
            var validar = true;
            if(string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Senha))
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
