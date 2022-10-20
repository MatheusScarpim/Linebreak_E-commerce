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
        DateTime thisDay = DateTime.Today;
        public string Incluir(Modelo.Modelo_User usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO usuarioslinebreak ")
              .Append("VALUES (DEFAULT, @cpf, @nomeusu, @niver, @email, @senha, @numero,@datacriado,@excluido); SELECT currval('usuarioslinebreak_idusuario_seq')");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@cpf", usuario.cpf);
                    cmd.Parameters.AddWithValue("@nomeusu", usuario.nomeusu);
                    cmd.Parameters.AddWithValue("@niver", usuario.niver);
                    cmd.Parameters.AddWithValue("@email", usuario.email);
                    cmd.Parameters.AddWithValue("@senha", usuario.senha);
                    cmd.Parameters.AddWithValue("@numero", usuario.numero);
                    cmd.Parameters.AddWithValue("@datacriado", thisDay);
                    cmd.Parameters.AddWithValue("@excluido", "n");
                    conn.Open();
                    NpgsqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    string idUser = dr[0].ToString();
                    conn.Close();
                    return idUser;
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
        public int Excluir(Modelo.Modelo_User usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("update usuarioslinebreak set excluido = 's', dataexcluido = @dtexcluido WHERE idusuario = @idusuario");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idusuario", usuario.idusuario);
                    cmd.Parameters.AddWithValue("@dtexcluido", usuario.Data_Excluido.ToString("MM/dd/yyyy"));

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
        public int Recuperar(Modelo.Modelo_User usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("update usuarioslinebreak set excluido = 'n' WHERE idusuario = @idusuario");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idusuario", usuario.idusuario);

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
        public int Atualizar(Modelo.Modelo_User usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("UPDATE usuarioslinebreak SET cpf = @cpf, nomeusu = @nomeusu, niver = @niver, email = @email, senha = @senha, numero = @numero WHERE idusuario = @idusuario; ");
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idusuario", usuario.idusuario);
                    cmd.Parameters.AddWithValue("@cpf", usuario.cpf);
                    cmd.Parameters.AddWithValue("@nomeusu", usuario.nomeusu);
                    cmd.Parameters.AddWithValue("@niver", usuario.niver);
                    cmd.Parameters.AddWithValue("@email", usuario.email);
                    cmd.Parameters.AddWithValue("@senha", usuario.senha);
                    cmd.Parameters.AddWithValue("@numero", usuario.numero);
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