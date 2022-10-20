using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteSQL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public static bool adm;

   
        private void btnConfigBanco_Click(object sender, EventArgs e)
        {
            frmconfig frmconfig= new frmconfig();
            frmconfig.Show();
        }

        private void btnVerCompras_Click(object sender, EventArgs e)
        {
            frmVerCompras verCompras = new frmVerCompras();
            verCompras.Show();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadProduto cadProduto = new frmCadProduto();
            cadProduto.Show();
        }

        private void btnCadUser_Click(object sender, EventArgs e)
        {
            frmCadUser cadUser = new frmCadUser();
            cadUser.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(adm == true)
            {
                btnCadProduto.Enabled = true;
                btnConfigBanco.Enabled = true;
                btnCadUser.Enabled = true;
            }
            else
            {
                btnCadProduto.Enabled = false;
                btnConfigBanco.Enabled = false;
                btnCadUser.Enabled = false;
            }

        }
        public void Open_Form()
        {
            Login Login = new Login();
            if (Application.OpenForms.OfType<Login>().Count() > 0)
            {
                MessageBox.Show("Formulário já está aberto");
            }
            else
            {
                Login.Show();
                Application.Run(Login);
            }

        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Open_Form);
            t.Start();
            Thread.Sleep(100);
            this.Close();
        }
    }
}
