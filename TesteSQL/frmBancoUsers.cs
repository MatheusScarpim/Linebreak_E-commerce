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
    public partial class frmBancoUsers : Form
    {
        public frmBancoUsers()
        {
            InitializeComponent();
        }
        private void dadosLogado()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT idusuario,cpf,nomeusu,niver,email,numero,datacriado from usuarioslinebreak where email = @email");
                NpgsqlDataReader dr;
                NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddWithValue("@email", DAL.Login_DAL.loginPes);
                conn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                //NomeCliente não é membro da classe Contas
                this.lblid.Text = dr[0].ToString();
                this.lblcpf.Text = dr[1].ToString();
                this.lblnome.Text = dr[2].ToString();
                this.lblAniversario.Text = dr[3].ToString();
                this.lblemail.Text = dr[4].ToString();
                this.lbltelefone.Text = dr[5].ToString();
                this.lbldatacriado.Text = dr[6].ToString();
            }
        }

        private void frmBancoUsers_Load(object sender, EventArgs e)
        {
            dadosLogado();
            bool adm = new DAL.Login_DAL().verificarAdm();
            if(!adm)
            {
                lblAdm.Visible = false;
            }
            else
            {
                lblAdm.Visible = true;
            }
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dt;
            bool adm = new DAL.Login_DAL().verificarAdm();
            using (NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD()))
            {
                if (!adm)
                {
                    sb.Append("select * from compralinebreak where idusuario = @idusuario");
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                        int id = Convert.ToInt16(lblid.Text);
                        cmd.Parameters.AddWithValue("@idusuario", id);
                        conn.Open();
                        dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        conn.Close();
                        dgvDataSouce.DataSource = null;
                        dgvDataSouce.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    sb.Append("select * from compralinebreak");
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand(sb.ToString(), conn);
                        conn.Open();
                        dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        conn.Close();
                        dgvDataSouce.DataSource = null;
                        dgvDataSouce.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }

}
