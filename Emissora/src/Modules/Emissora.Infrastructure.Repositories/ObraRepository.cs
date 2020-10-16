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
    public class ObraRepository : IObraRepository
    {
        private readonly IConfiguration _configuration;
        public ObraRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Obra> Get()
        {
            try
            {
                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var obraList = new List<Obra>();

                    var sqlCmd = $"Select * From Obra";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var obra = new Obra(int.Parse(reader["id"].ToString()),
                                                reader["NomeObra"].ToString(),
                                                float.Parse(reader["Orcamento"].ToString()));

                            obraList.Add(obra);
                        }

                        return obraList;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Obra GetById(int id)
        {
            try
            {
                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var sqlCmd = $"Select * From Obra Where Id ={id} ";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var obra = new Obra(int.Parse(reader["id"].ToString()),
                                                reader["NomeObra"].ToString(),
                                                float.Parse(reader["Orcamento"].ToString()));

                            return obra;
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

        public int Insert(Obra obra)
        {
            try
            {

                using (var con = new SqlConnection(_configuration["ConnectionString"]))
                {
                    var sqlCmd = @"INSERT INTO 
                                    Obra ( NomeObra,
                                           Orcamento); Select scope identity(); 
                                    VALUES (@nome, 
                                            @orcamento)";

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("NomeObra", obra.NomeObra);
                        cmd.Parameters.AddWithValue("Orcamento", obra.Orcamento);
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
