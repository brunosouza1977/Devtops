using Emissora.Domain.Entities;
using Emissora.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Emissora.Infrastructure.Repositories
{
    public class ElencoRepository : IElencoRepository

    {
        private readonly IConfiguration _configuration;
        public IEnumerable<Elenco> Get()
        {

            try
            {
                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var elencolist = new List<Elenco>();

                    var sqlCmd = $"Select * From Elenco";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var elenco = new Elenco(int.Parse(reader["id"].ToString()),
                                                reader["idAtor"].ToString(),
                                                float.Parse(reader["idObra"].ToString()));

                            elencolist.Add(elenco);
                        }

                        return elencolist;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Elenco GetById(int id)
        {
            try
            {
                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var sqlCmd = $"Select * From Elenco Where Id ={id} ";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var elenco = new Elenco(int.Parse(reader["id"].ToString()),
                                                reader["idAtor"].ToString(),
                                                float.Parse(reader["idObra"].ToString()));

                            return elenco;
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

        public int Insert(Elenco elenco)
        {
            try
            {

                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var sqlCmd = @"INSERT INTO 
                                    Elenco ( idAtor,
                                           idObra); Select scope identity(); 
                                    VALUES (@idAtor, 
                                            @idObra)";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("idAtor", elenco.Idator);
                        cmd.Parameters.AddWithValue("idObra", elenco.Idobra);
                        con.Open();
                        var id = cmd.ExecuteScalar();
                        return int.Parse(id.ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

