using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class Produtos_DAL
    {

        public int Incluir(Modelo.Modelo_Produto usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO produtolinebreak ")
              .Append("VALUES (DEFAULT, @nomeper, @preco, @qntd, @descricao, @excluido, @imagem);");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@nomeper", usuario.Nomeper);
                    cmd.Parameters.AddWithValue("@preco", usuario.Quantidade);
                    cmd.Parameters.AddWithValue("@qntd", usuario.Valor);
                    cmd.Parameters.AddWithValue("@descricao", usuario.Descricao);
                    cmd.Parameters.AddWithValue("@excluido", "n");
                    cmd.Parameters.AddWithValue("@imagem", usuario.imagem.ToString());

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
        public int Excluir(Modelo.Modelo_Produto usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("update produtolinebreak set excluido = 's', dataexcluido = @dtexcluido WHERE idproduto = @idperfume");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idperfume", usuario.idPerfume);
                    cmd.Parameters.AddWithValue("@dtexcluido", usuario.Data_Excluido);

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
        public int Recuperar(Modelo.Modelo_Produto usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("update produtolinebreak set excluido = 'n' WHERE idproduto = @idperfume");
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
        public int Atualizar(Modelo.Modelo_Produto usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("UPDATE produtolinebreak SET nomeper = @nomeper, qntd = @qntd, preco = @preco, descricao = @descricao, campoimagem = @imagem WHERE idproduto = @idperfume; ");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idperfume", usuario.idPerfume);
                    cmd.Parameters.AddWithValue("@nomeper", usuario.Nomeper);
                    cmd.Parameters.AddWithValue("@qntd", usuario.Quantidade);
                    cmd.Parameters.AddWithValue("@preco", usuario.Valor);
                    cmd.Parameters.AddWithValue("@descricao", usuario.Descricao);
                    cmd.Parameters.AddWithValue("@imagem", usuario.imagem);
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