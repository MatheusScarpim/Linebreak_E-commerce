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
using Npgsql;

namespace TesteSQL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string Email;
        public static string Senha;
        frmMenu frmMenu = new frmMenu();

        public void Open_Form()
        {

            if (Application.OpenForms.OfType<frmMenu>().Count() > 0)
            {
                MessageBox.Show("Formulário já está aberto");
            }
            else
            {
                frmMenu.Show();
                Application.Run(frmMenu);
            }

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            bool tem = new DAL.Login_DAL().verificarLogin(txtUser.Text, txtSenha.Text);
            try
            {
                if(tem == true)
                {
                    bool adm = new DAL.Login_DAL().verificarAdm(txtUser.Text, txtSenha.Text);
                    if(adm == true)
                    {
                        frmMenu.adm = true;
                    }
                    else
                    {
                        frmMenu.adm = false;
                    }
                    Email = txtUser.Text;
                    Senha = txtSenha.Text;
                    Thread t = new Thread(Open_Form);
                    t.Start();
                    Thread.Sleep(500);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
            catch
            {

            }
        }
    }
}
