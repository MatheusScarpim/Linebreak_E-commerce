using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public static string email;
        
        private void btnLogar_Click(object sender, EventArgs e)
        {

            bool tem = new DAL.Login_DAL().verificarLogin(txtUser.Text, txtSenha.Text);
            try
            {
                if(tem == true)
                {
                    frmBancoUsers bancoUsers = new frmBancoUsers();
                    bancoUsers.Show();
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
