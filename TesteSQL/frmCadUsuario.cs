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

namespace AulaSqlServer
{
    public partial class frmCadUsuario : Form
    {
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

                MessageBox.Show("Usuario Cadstrado Com Sucesso o Id Gerrado e " + codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
