namespace TesteSQL
{
    partial class frmCadProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bGravar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDataSouce = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtExcluido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPerfume = new System.Windows.Forms.TextBox();
            this.btnExcluidos = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnAttdados = new System.Windows.Forms.Button();
            this.btnAddPlanilha = new System.Windows.Forms.Button();
            this.pcImagem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(188, 76);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 20);
            this.txtValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(348, 76);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(151, 20);
            this.txtQtd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // bGravar
            // 
            this.bGravar.Location = new System.Drawing.Point(603, 388);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(243, 49);
            this.bGravar.TabIndex = 8;
            this.bGravar.Text = "Gravar";
            this.bGravar.UseVisualStyleBackColor = true;
            this.bGravar.Click += new System.EventHandler(this.bGravar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(505, 76);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(151, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(502, 60);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(55, 13);
            this.Descricao.TabIndex = 10;
            this.Descricao.Text = "Descrição";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(429, 464);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 31);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id do perfume";
            // 
            // dgvDataSouce
            // 
            this.dgvDataSouce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSouce.Location = new System.Drawing.Point(31, 102);
            this.dgvDataSouce.Name = "dgvDataSouce";
            this.dgvDataSouce.Size = new System.Drawing.Size(778, 280);
            this.dgvDataSouce.TabIndex = 16;
            this.dgvDataSouce.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataSouce_CellClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(31, 421);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(148, 31);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Atualizar Tabela";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtExcluido
            // 
            this.txtExcluido.Location = new System.Drawing.Point(658, 76);
            this.txtExcluido.Name = "txtExcluido";
            this.txtExcluido.Size = new System.Drawing.Size(151, 20);
            this.txtExcluido.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Excluido";
            // 
            // txtIdPerfume
            // 
            this.txtIdPerfume.Location = new System.Drawing.Point(429, 432);
            this.txtIdPerfume.Name = "txtIdPerfume";
            this.txtIdPerfume.Size = new System.Drawing.Size(151, 20);
            this.txtIdPerfume.TabIndex = 20;
            // 
            // btnExcluidos
            // 
            this.btnExcluidos.Location = new System.Drawing.Point(31, 461);
            this.btnExcluidos.Name = "btnExcluidos";
            this.btnExcluidos.Size = new System.Drawing.Size(148, 31);
            this.btnExcluidos.TabIndex = 21;
            this.btnExcluidos.Text = "Mostrar Excluidos";
            this.btnExcluidos.UseVisualStyleBackColor = true;
            this.btnExcluidos.Click += new System.EventHandler(this.btnExcluidos_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(513, 464);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(67, 31);
            this.btnRecuperar.TabIndex = 22;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnAttdados
            // 
            this.btnAttdados.Location = new System.Drawing.Point(603, 446);
            this.btnAttdados.Name = "btnAttdados";
            this.btnAttdados.Size = new System.Drawing.Size(243, 49);
            this.btnAttdados.TabIndex = 23;
            this.btnAttdados.Text = "Atualizar Dados";
            this.btnAttdados.UseVisualStyleBackColor = true;
            this.btnAttdados.Click += new System.EventHandler(this.btnAttdados_Click);
            // 
            // btnAddPlanilha
            // 
            this.btnAddPlanilha.Location = new System.Drawing.Point(221, 461);
            this.btnAddPlanilha.Name = "btnAddPlanilha";
            this.btnAddPlanilha.Size = new System.Drawing.Size(143, 34);
            this.btnAddPlanilha.TabIndex = 24;
            this.btnAddPlanilha.Text = "Adicionar dados por planilha";
            this.btnAddPlanilha.UseVisualStyleBackColor = true;
            this.btnAddPlanilha.Click += new System.EventHandler(this.btnAddPlanilha_Click);
            // 
            // pcImagem
            // 
            this.pcImagem.Location = new System.Drawing.Point(824, 21);
            this.pcImagem.Name = "pcImagem";
            this.pcImagem.Size = new System.Drawing.Size(111, 100);
            this.pcImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImagem.TabIndex = 25;
            this.pcImagem.TabStop = false;
            this.pcImagem.Click += new System.EventHandler(this.abrirImagem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(829, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.abrirImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcImagem);
            this.Controls.Add(this.btnAddPlanilha);
            this.Controls.Add(this.btnAttdados);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnExcluidos);
            this.Controls.Add(this.txtIdPerfume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExcluido);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvDataSouce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.bGravar);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmCadProduto";
            this.Text = "Cadastro Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bGravar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDataSouce;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtExcluido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPerfume;
        private System.Windows.Forms.Button btnExcluidos;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnAttdados;
        private System.Windows.Forms.Button btnAddPlanilha;
        private System.Windows.Forms.PictureBox pcImagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}