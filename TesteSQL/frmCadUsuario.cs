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

namespace AulaSqlServer
{
    public partial class frmCadUsuario : Form
    {
        private int rowIndex = -1;
        public frmCadUsuario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmconfig conf = new frmconfig();
            conf.Show();
        }

        private void bGravar_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            int quantidade = Convert.ToInt32(txtQtd.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            try
            {
                Modelo.Modelo_Usuario usuario = new Modelo.Modelo_Usuario();
                usuario.Nomeper = (txtNome.Text);
                usuario.Quantidade = (quantidade);
                usuario.Valor = (valor);
                usuario.Descricao = (txtDescricao.Text);

                string codigo = new BLL.Usuario_BLL().Incluir(usuario).ToString();

                MessageBox.Show("Usuario Cadstrado Com Sucesso o Id Gerado e " + codigo);
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
                sql = @"select * from perfume where excluido = 'n' order by idperfume;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataSouce.DataSource = null;
                dgvDataSouce.DataSource = dt;
            }
            catch(Exception ex)
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
                sql = @"select * from perfume where excluido = 's' order by idperfume;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataSouce.DataSource = null;
                dgvDataSouce.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
 
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void dgvDataSouce_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdPerfume.Text = dgvDataSouce.Rows[e.RowIndex].Cells["idperfume"].Value.ToString();
                txtNome.Text = dgvDataSouce.Rows[e.RowIndex].Cells["nomeper"].Value.ToString();
                txtQtd.Text = dgvDataSouce.Rows[e.RowIndex].Cells["qntd"].Value.ToString();
                txtValor.Text = dgvDataSouce.Rows[e.RowIndex].Cells["valor"].Value.ToString();
                txtDescricao.Text = dgvDataSouce.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                txtExcluido.Text = dgvDataSouce.Rows[e.RowIndex].Cells["excluido"].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idperfume = Convert.ToInt32(txtIdPerfume.Text);
            try
            {
                Modelo.Modelo_Usuario usuario = new Modelo.Modelo_Usuario();
                usuario.idPerfume = (idperfume);

                string codigo = new BLL.Usuario_BLL().Excluir(usuario).ToString();

                MessageBox.Show("O id " + idperfume + " foi excluido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarExcluidos();
        }

        private void btnExcluidos_Click(object sender, EventArgs e)
        {
            MostrarExcluidos();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            int idperfume = Convert.ToInt32(txtIdPerfume.Text);
            try
            {
                Modelo.Modelo_Usuario usuario = new Modelo.Modelo_Usuario();
                usuario.idPerfume = (idperfume);

                string codigo = new BLL.Usuario_BLL().Recuperar(usuario).ToString();

                MessageBox.Show("O id " + idperfume + " foi recuperado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarTodos();
        }

        private void btnAttdados_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txtQtd.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            int idperfume = Convert.ToInt32(txtIdPerfume.Text);
            try
            {
                Modelo.Modelo_Usuario usuario = new Modelo.Modelo_Usuario();
                usuario.idPerfume = (idperfume);
                usuario.Nomeper = (txtNome.Text);
                usuario.Quantidade = (quantidade);
                usuario.Valor = (valor);
                usuario.Descricao = (txtDescricao.Text);
                usuario.Excluido = (txtExcluido.Text);

                string codigo = new BLL.Usuario_BLL().Atualizar(usuario).ToString();

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
