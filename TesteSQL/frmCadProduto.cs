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
using System.Drawing.Imaging;
using System.IO;

namespace TesteSQL
{
    public partial class frmCadProduto : Form
    {
        DateTime thisDay = DateTime.Today;
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void bGravar_Click(object sender, EventArgs e)
        {
            try
            {
                int quantidade = Convert.ToInt32(txtQtd.Text);
                double valor = Convert.ToDouble(txtValor.Text);
                Modelo.Modelo_Produto usuario = new Modelo.Modelo_Produto();
                MemoryStream m = new MemoryStream();
                Image image = pcImagem.Image;
                string base64String = null;
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                usuario.imagem = (base64String);
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
                sql = @"select * from produtolinebreak where excluido = 'n' order by idproduto;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvDataSouce.DataSource = null;
                dgvDataSouce.DataSource = dt;
            }
            catch(Exception)
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
                sql = @"select * from produtolinebreak where excluido = 's' order by idproduto;";
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
                txtIdPerfume.Text = dgvDataSouce.Rows[e.RowIndex].Cells["idproduto"].Value.ToString();
                txtNome.Text = dgvDataSouce.Rows[e.RowIndex].Cells["nomeper"].Value.ToString();
                txtValor.Text = dgvDataSouce.Rows[e.RowIndex].Cells["qntd"].Value.ToString();
                txtQtd.Text = dgvDataSouce.Rows[e.RowIndex].Cells["preco"].Value.ToString();
                txtDescricao.Text = dgvDataSouce.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                try
                {
                    string base64 = dgvDataSouce.Rows[e.RowIndex].Cells["campoimagem"].Value.ToString();
                    pcImagem.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64))); ;
                }
                catch
                {

                }
                txtExcluido.Text = dgvDataSouce.Rows[e.RowIndex].Cells["excluido"].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int idperfume = Convert.ToInt32(txtIdPerfume.Text);
                Modelo.Modelo_Produto usuario = new Modelo.Modelo_Produto();
                usuario.idPerfume = (idperfume);
                usuario.Data_Excluido = thisDay;

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
            try
            {
                int idperfume = Convert.ToInt32(txtIdPerfume.Text);
                Modelo.Modelo_Produto usuario = new Modelo.Modelo_Produto();
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
            
            try
            {
                int quantidade = Convert.ToInt32(txtValor.Text);
                double valor = Convert.ToDouble(txtQtd.Text);
                int idperfume = Convert.ToInt32(txtIdPerfume.Text);
                MemoryStream m = new MemoryStream();
                Image image = pcImagem.Image;
                string base64String = null;
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                Modelo.Modelo_Produto usuario = new Modelo.Modelo_Produto();
                usuario.imagem = (base64String);
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

        private void btnAddPlanilha_Click(object sender, EventArgs e)
        {
            frmAddPlanilhas conf = new frmAddPlanilhas();
            conf.Show();
        }

        private void ConfigurarBanco_Click(object sender, EventArgs e)
        {
            frmconfig conf = new frmconfig();
            conf.Show();
        }

        private void BancoUser_Click(object sender, EventArgs e)
        {
            Login conf = new Login();
            conf.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCadUser conf = new frmCadUser();
            conf.Show();
        }

        private void abrirImagem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Imagem " + openFileDialog1.FileName + " foi importada");
                    pcImagem.ImageLocation = openFileDialog1.FileName;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
