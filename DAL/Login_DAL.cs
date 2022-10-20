using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class Login_DAL
    {
        public bool verificarLogin(string login, string senha)
        {
            StringBuilder sb = new StringBuilder();
            NpgsqlDataReader dr;
            bool tem = false;
            sb.Append("select * from usuarioslinebreak where email = @logar and senha = @senha");
            using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
            {
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@logar", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        tem = true;
                    }
                    conn.Close();
                }
                catch(Exception)
                {

                }
            }
            return tem;
        }

        public bool verificarAdm(string login, string senha)
        {
            StringBuilder sb = new StringBuilder();
            NpgsqlDataReader dr;
            bool tem = false;
            sb.Append("select * from usuarioslinebreak where email = @logar and senha = @senha and adm = true");
            using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
            {
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddWithValue("@logar", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        tem = true;
                    }
                    conn.Close();
                }
                catch (Exception)
                {

                }
            }
            return tem;
        }
    }
}
