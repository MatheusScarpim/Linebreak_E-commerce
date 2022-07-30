using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class Usuario_DAL
    {

        public int Incluir(Modelo.Modelo_Usuario usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO perfume ")
              .Append("VALUES (DEFAULT, @nomeper, @qntd, @valor, @descricao);");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@nomeper", usuario.Nomeper);
                    cmd.Parameters.AddWithValue("@qntd", usuario.Quantidade);
                    cmd.Parameters.AddWithValue("@valor", usuario.Valor);
                    cmd.Parameters.AddWithValue("@descricao", usuario.Descricao);

                    conn.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (NpgsqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}