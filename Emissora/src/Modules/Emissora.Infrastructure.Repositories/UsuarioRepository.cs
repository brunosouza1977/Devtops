using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Emissora.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private List<Usuario> usuarios;
        private readonly IConfiguration _configuration;
        public UsuarioRepository(IConfiguration configuration)
        {
            usuarios = new List<Usuario>();
            _configuration = configuration;
        }
        public IEnumerable<Usuario> Get()
        {
            try
            {
                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var usuarioList =new List<Usuario>();
                    
                    var sqlCmd = $"Select * From Usuarios";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var usuario = new Usuario(int.Parse(reader["id"].ToString()),
                                                       reader["Nome"].ToString(),
                                                       int.Parse(reader["Cpf"].ToString()),
                                                       reader["Login"].ToString(),
                                                       reader["Senha"].ToString(),
                                                       int.Parse(reader["TipoPerfil"].ToString()),
                                                       float.Parse(reader["Cache"].ToString()),
                                                       int.Parse(reader["GeneroObra"].ToString()),
                                                       DateTime.Parse(reader["DataDisponibilidade"].ToString()),
                                                       reader["Cidade"].ToString(),
                                                       reader["Estado"].ToString(),
                                                       int.Parse(reader["Cep"].ToString()),
                                                       DateTime.Parse(reader["DataCadastro"].ToString()));

                            usuarioList.Add(usuario);
                        }

                        return usuarioList;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario GetById(int id)
        {
            try
            {
                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var sqlCmd = $"Select * From Usuarios Where Id={id}";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var usuario = new Usuario(int.Parse(reader["id"].ToString()),
                                                       reader["Nome"].ToString(),
                                                       int.Parse(reader["Cpf"].ToString()),
                                                       reader["Login"].ToString(),
                                                       reader["Senha"].ToString(),
                                                       int.Parse(reader["TipoPerfil"].ToString()),
                                                       float.Parse(reader["Cache"].ToString()),
                                                       int.Parse(reader["GeneroObra"].ToString()),
                                                       DateTime.Parse(reader["DataDisponibilidade"].ToString()),
                                                       reader["Cidade"].ToString(),
                                                       reader["Estado"].ToString(),
                                                       int.Parse(reader["Cep"].ToString()),
                                                       DateTime.Parse(reader["DataCadastro"].ToString()));

                            return usuario;
                        }

                        return default;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario Delete(int id)
        {
            try
            {
                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var sqlCmd = $"DELETE FROM Usuarios WHERE ID={id}";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        return default;
                    }
                }
             }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Insert(Usuario usuario)
        {
            try
            {

                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                var sqlCmd = @"INSERT INTO 
                                    Usuarios ( Nome,
                                                Cpf,
                                                Login,
                                                Senha,
                                                TipoPerfil,
                                                Cache,
                                                GeneroObra,
                                                DataDisponibilidade,
                                                Cidade,
                                                Estado,
                                                Cep,
                                                DataCadastro) 
                                    VALUES (@nome, 
                                            @cpf,
                                            @login, 
                                            @senha,
                                            @tipoperfil,
                                            @cache,
                                            @generoobra,
                                            @datadisponibilidade, 
                                            @cidade,
                                            @estado,
                                            @cep,
                                            @datacadastro); Select scope_identity();";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("cpf", usuario.Cpf);
                        cmd.Parameters.AddWithValue("login", usuario.Login);
                        cmd.Parameters.AddWithValue("senha", usuario.Senha);
                        cmd.Parameters.AddWithValue("tipoperfil", usuario.TipoPerfil);
                        cmd.Parameters.AddWithValue("cache", usuario.Cache);
                        cmd.Parameters.AddWithValue("generoobra", usuario.GeneroObra);
                        cmd.Parameters.AddWithValue("datadisponibilidade", usuario.DataDisponibilidade);
                        cmd.Parameters.AddWithValue("cidade", usuario.Cidade);  
                        cmd.Parameters.AddWithValue("estado", usuario.Estado);
                        cmd.Parameters.AddWithValue("cep", usuario.Cep);
                        cmd.Parameters.AddWithValue("datacadastro", usuario.DataCadastro);

                        con.Open();
                        var id = cmd.ExecuteScalar();
                        return int.Parse(id.ToString());
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
