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
              .Append("VALUES (DEFAULT, @nomeper, @qntd, @valor, @descricao, @excluido);");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@nomeper", usuario.Nomeper);
                    cmd.Parameters.AddWithValue("@qntd", usuario.Quantidade);
                    cmd.Parameters.AddWithValue("@valor", usuario.Valor);
                    cmd.Parameters.AddWithValue("@descricao", usuario.Descricao);
                    cmd.Parameters.AddWithValue("@excluido", "n");

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
        public int Excluir(Modelo.Modelo_Usuario usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("update perfume set excluido = 's' WHERE idperfume = @idperfume");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idperfume", usuario.idPerfume);

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
        public int Recuperar(Modelo.Modelo_Usuario usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("update perfume set excluido = 'n' WHERE idperfume = @idperfume");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idperfume", usuario.idPerfume);

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
        public int Atualizar(Modelo.Modelo_Usuario usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("UPDATE perfume SET nomeper = @nomeper, qntd = @qntd, valor = @valor, descricao = @descricao WHERE idperfume = @idperfume; ");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idperfume", usuario.idPerfume);
                    cmd.Parameters.AddWithValue("@nomeper", usuario.Nomeper);
                    cmd.Parameters.AddWithValue("@qntd", usuario.Quantidade);
                    cmd.Parameters.AddWithValue("@valor", usuario.Valor);
                    cmd.Parameters.AddWithValue("@descricao", usuario.Descricao);
                    cmd.Parameters.AddWithValue("@excluido", usuario.Excluido);

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