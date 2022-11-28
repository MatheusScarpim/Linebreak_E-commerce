using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteSQL;
using Npgsql;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;
using Modelo;
using static Microsoft.Graph.CoreConstants;

namespace TesteSQL
{
    public partial class frmCadUser : Form
    {
        DateTime thisDay = DateTime.Today;
        public frmCadUser()
        {
            InitializeComponent();
        }
        public string id = "";
        private void bGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Modelo_User usuario = new Modelo.Modelo_User();
                usuario.cpf = (txtCpf.Text);
                usuario.nomeusu = (txtUsuario.Text);
                usuario.niver = (dtNascimento.Value);
                usuario.email = (txtEmail.Text);
                usuario.senha = (txtSenha.Text);
                usuario.numero = (txtNumero.Text);
                usuario.Data_Criado = (thisDay);

                string codigo = new DAL.Usuario_DAL().Incluir(usuario).ToString();


                MessageBox.Show("Usuario Cadstrado Com Sucesso o Id Gerado e " + codigo);

                string _urlBase = "https://3baf-200-145-153-161.sa.ngrok.io/sendmessage";
                using(var client = new HttpClient())
                {
                    
                    var endpoint = new Uri(_urlBase);
                    var newPost = new Post()
                    {
                        telnumber = "55" + txtNumero.Text,
                        message = "Cadastro pelo C#",
                        idPessoa = codigo,
                        nomePessoa = txtUsuario.Text
                    };
                    var newPostJson = JsonConvert.SerializeObject(newPost);
                    var payload = new StringContent(newPostJson, System.Text.Encoding.UTF8, "application/json");
                    var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsByteArrayAsync().Result;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTodos()
        {
            NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD());
            NpgsqlCommand cmd;
            DataTable dt;
            string sql;
            try
            {
                conn.Open();
                sql = @"select * from usuarioslinebreak where excluido = 'n' order by idusuario;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataSouce.DataSource = null;
                dgvDataSouce.DataSource = dt;
            }
            catch (Exception)
            {
                conn.Close();
            }
        }
        private void MostrarExcluidos()
        {
            NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD());
            NpgsqlCommand cmd;
            DataTable dt;
            string sql;
            try
            {
                conn.Open();
                sql = @"select * from usuarioslinebreak where excluido = 's' order by idusuario;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataSouce.DataSource = null;
                dgvDataSouce.DataSource = dt;
            }
            catch (Exception)
            {
                conn.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void dgvDataSouce_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdusuario.Text = dgvDataSouce.Rows[e.RowIndex].Cells["idusuario"].Value.ToString();
                txtCpf.Text = dgvDataSouce.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtUsuario.Text = dgvDataSouce.Rows[e.RowIndex].Cells["nomeusu"].Value.ToString();
                dtNascimento.Text = dgvDataSouce.Rows[e.RowIndex].Cells["niver"].Value.ToString();
                txtEmail.Text = dgvDataSouce.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtSenha.Text = dgvDataSouce.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                txtNumero.Text = dgvDataSouce.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            }
        }


        private void btnExcluidos_Click(object sender, EventArgs e)
        {
            MostrarExcluidos();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                int idperfume = Convert.ToInt32(txtIdusuario.Text);
                Modelo.Modelo_User usuario = new Modelo.Modelo_User();
                usuario.idusuario = (idperfume);
                string codigo = new DAL.Usuario_DAL().Recuperar(usuario).ToString();
                MessageBox.Show("Usuario Recuperar Com Sucesso o Id Gerado e " + codigo);
            }
            catch (Exception)
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int idperfume = Convert.ToInt32(txtIdusuario.Text);
                Modelo.Modelo_User usuario = new Modelo.Modelo_User();
                usuario.idusuario = (idperfume);
                string codigo = new DAL.Usuario_DAL().Excluir(usuario).ToString();
                MessageBox.Show("Usuario Excluir Com Sucesso o Id Gerado e " + codigo);
            }
            catch (Exception)
            {

            }
        }

        private void btnAttdados_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Modelo_User usuario = new Modelo.Modelo_User();
                int id = Convert.ToInt32(txtIdusuario.Text);
                usuario.idusuario = (id);
                usuario.cpf = (txtCpf.Text);
                usuario.nomeusu = (txtUsuario.Text);
                usuario.niver = (dtNascimento.Value);
                usuario.email = (txtEmail.Text);
                usuario.senha = (txtSenha.Text);
                usuario.numero = (txtNumero.Text);
                usuario.Data_Criado = (thisDay);

                string codigo = new DAL.Usuario_DAL().Atualizar(usuario).ToString();

                MessageBox.Show("Usuario Cadstrado Com Sucesso o Id Gerado e " + codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarTodos();
        }


    }
}
