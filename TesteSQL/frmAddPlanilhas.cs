using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Npgsql;

namespace TesteSQL
{
    public partial class frmAddPlanilhas : Form
    {
        Excel.Application app = new Excel.Application();
        Workbook pasta;
        Worksheet plan;
        public frmAddPlanilhas()
        {
            InitializeComponent();
        }

        private void btnAddplanilha_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Planilha " + openFileDialog1.FileName + " foi importada");
                lblNomePlanilha.Text = openFileDialog1.FileName;
            }
        }
        private void MostrarTodos()
        {
            NpgsqlConnection conn = new NpgsqlConnection(Funcoes.ConexaoBD.RetornaConexaoBD());
            NpgsqlCommand cmd;
            System.Data.DataTable dt;
            string sql;
            try
            {
                conn.Open();
                sql = @"select * from perfume order by idperfume;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new System.Data.DataTable();
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
        private void ExportarPlanilha()
        {
            if (dgvDataSouce.Rows.Count > 0)
            {
                try
                {
                    app.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvDataSouce.Columns.Count + 1; i++)
                    {
                        app.Cells[1, i] = dgvDataSouce.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvDataSouce.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvDataSouce.Columns.Count; j++)
                        {
                            app.Cells[i + 2, j + 1] = dgvDataSouce.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    app.Columns.AutoFit();
                    //
                    app.Visible = true;
                    app.Worksheets[1].Name = "Cadastrar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    app.Quit();
                }
            }
        }
        private void ImportarPlanilha()
        {
            Modelo.Modelo_Usuario usuario = new Modelo.Modelo_Usuario();
            pasta = app.Workbooks.Open(lblNomePlanilha.Text);
            plan = pasta.Worksheets["Cadastrar"];
            bool valor = true;
            int i = 2;
            while (valor == true)
            {
                try
                {
                    usuario.Nomeper = (plan.Cells[i, 2].Value.ToString());
                    int Quantidade = Convert.ToInt32(plan.Cells[i, 3].Value.ToString());
                    double Valor = Convert.ToDouble(plan.Cells[i, 4].Value.ToString());
                    usuario.Quantidade = (Quantidade);
                    usuario.Valor = (Valor);
                    usuario.Descricao = (plan.Cells[i, 5].Value.ToString());
                    string codigo = new BLL.Usuario_BLL().Incluir(usuario).ToString();
                    i++;
                }
                catch
                {
                    valor = false;
                    pasta.Close();
                }
            }
        }

        private void btnCarregarPlanilha_Click(object sender, EventArgs e)
        {
            ImportarPlanilha();
        }

        private void btnBaixarPlanilha_Click(object sender, EventArgs e)
        {
            ExportarPlanilha();
        }


        private void btnAttDados_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }
    }
}
