namespace TesteSQL
{
    partial class frmCadUser
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dgvDataSouce = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblniver = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.NOme = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtIdusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAttdados = new System.Windows.Forms.Button();
            this.btnExcluidos = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSouce)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(742, 33);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(151, 20);
            this.txtSenha.TabIndex = 29;
            // 
            // dgvDataSouce
            // 
            this.dgvDataSouce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSouce.Location = new System.Drawing.Point(25, 120);
            this.dgvDataSouce.Name = "dgvDataSouce";
            this.dgvDataSouce.Size = new System.Drawing.Size(815, 280);
            this.dgvDataSouce.TabIndex = 28;
            this.dgvDataSouce.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataSouce_CellClick);
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(582, 17);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(32, 13);
            this.Descricao.TabIndex = 27;
            this.Descricao.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(585, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // lblniver
            // 
            this.lblniver.AutoSize = true;
            this.lblniver.Location = new System.Drawing.Point(352, 17);
            this.lblniver.Name = "lblniver";
            this.lblniver.Size = new System.Drawing.Size(63, 13);
            this.lblniver.TabIndex = 24;
            this.lblniver.Text = "Nascimento";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(195, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 20);
            this.txtUsuario.TabIndex = 23;
            // 
            // NOme
            // 
            this.NOme.AutoSize = true;
            this.NOme.Location = new System.Drawing.Point(192, 17);
            this.NOme.Name = "NOme";
            this.NOme.Size = new System.Drawing.Size(87, 13);
            this.NOme.TabIndex = 22;
            this.NOme.Text = "Nome do úsuario";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(38, 33);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(151, 20);
            this.txtCpf.TabIndex = 21;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(35, 17);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(27, 13);
            this.t.TabIndex = 20;
            this.t.Text = "CPF";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(665, 440);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(197, 32);
            this.btnGravar.TabIndex = 31;
            this.btnGravar.Text = "Cadastrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.bGravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(38, 81);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(151, 20);
            this.txtNumero.TabIndex = 32;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(578, 479);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(67, 31);
            this.btnRecuperar.TabIndex = 37;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtIdusuario
            // 
            this.txtIdusuario.Location = new System.Drawing.Point(494, 440);
            this.txtIdusuario.Name = "txtIdusuario";
            this.txtIdusuario.Size = new System.Drawing.Size(151, 20);
            this.txtIdusuario.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Id do úsuario";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(494, 479);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 31);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAttdados
            // 
            this.btnAttdados.Location = new System.Drawing.Point(665, 479);
            this.btnAttdados.Name = "btnAttdados";
            this.btnAttdados.Size = new System.Drawing.Size(202, 31);
            this.btnAttdados.TabIndex = 38;
            this.btnAttdados.Text = "Atualizar Dados";
            this.btnAttdados.UseVisualStyleBackColor = true;
            this.btnAttdados.Click += new System.EventHandler(this.btnAttdados_Click);
            // 
            // btnExcluidos
            // 
            this.btnExcluidos.Location = new System.Drawing.Point(41, 469);
            this.btnExcluidos.Name = "btnExcluidos";
            this.btnExcluidos.Size = new System.Drawing.Size(148, 31);
            this.btnExcluidos.TabIndex = 40;
            this.btnExcluidos.Text = "Mostrar Excluidos";
            this.btnExcluidos.UseVisualStyleBackColor = true;
            this.btnExcluidos.Click += new System.EventHandler(this.btnExcluidos_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(41, 429);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(148, 31);
            this.btnupdate.TabIndex = 39;
            this.btnupdate.Text = "Atualizar Tabela";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(355, 33);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(218, 20);
            this.dtNascimento.TabIndex = 41;
            // 
            // frmCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.btnExcluidos);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnAttdados);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.txtIdusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.dgvDataSouce);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblniver);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.NOme);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.t);
            this.Name = "frmCadUser";
            this.Text = "frmCadUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSouce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView dgvDataSouce;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblniver;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label NOme;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.TextBox txtIdusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAttdados;
        private System.Windows.Forms.Button btnExcluidos;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DateTimePicker dtNascimento;
    }
}