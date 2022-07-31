using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TesteSQL
{
    public partial class frmconfig : Form
    {
        public frmconfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBancoDeDados.dll");
                StringBuilder sb = new StringBuilder();
                NpgsqlConnection cnn;
                sb.Append("Server=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Port=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Database=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("User Id=").Append(arquivo.ReadLine()).Append(";");
                sb.Append("Password=").Append(arquivo.ReadLine()).Append(";");
                string connetionString = sb.ToString();
                cnn = new NpgsqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Connection Open !");
                cnn.Close();

            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados" + erro);
            }
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtInstancia.Text)) || (string.IsNullOrWhiteSpace(txtPorta.Text)) || (string.IsNullOrWhiteSpace(txtnmBanco.Text)) || (string.IsNullOrWhiteSpace(txtUser.Text)))
            {
                MessageBox.Show("Em branco");
            }
            else
            {
                try
                {
                    string connetionString;
                    NpgsqlConnection cnn;
                    connetionString = "Server=" + txtInstancia.Text + ";" + "Port=" + txtPorta.Text + ";" + "Database=" + txtnmBanco.Text + ";" + "User Id=" + txtUser.Text + ";" + "Password=" + txtSenha.Text + ";";
                    cnn = new NpgsqlConnection(connetionString);
                    cnn.Open();
                    MessageBox.Show("Connection Open !");
                    cnn.Close();
                }
                catch (NpgsqlException erro)
                {
                    MessageBox.Show("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados" + erro);
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtInstancia.Text)) || (string.IsNullOrWhiteSpace(txtPorta.Text)) || (string.IsNullOrWhiteSpace(txtnmBanco.Text)) || (string.IsNullOrWhiteSpace(txtUser.Text)))
            {
                MessageBox.Show("Em branco");
            }
            else
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBancoDeDados.dll", false);
                arquivo.WriteLine(txtInstancia.Text);
                arquivo.WriteLine(txtPorta.Text);
                arquivo.WriteLine(txtnmBanco.Text);
                arquivo.WriteLine(txtUser.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado com sucesso!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
