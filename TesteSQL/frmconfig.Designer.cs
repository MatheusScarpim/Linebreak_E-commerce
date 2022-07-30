namespace TesteSQL
{
    partial class frmconfig
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestar = new System.Windows.Forms.Button();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtnmBanco = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelporta = new System.Windows.Forms.Label();
            this.labelbanco = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.labelinstancia = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(36, 203);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(187, 70);
            this.btnTestar.TabIndex = 0;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // txtInstancia
            // 
            this.txtInstancia.Location = new System.Drawing.Point(109, 15);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(168, 20);
            this.txtInstancia.TabIndex = 1;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(177, 44);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 20);
            this.txtPorta.TabIndex = 18;
            // 
            // txtnmBanco
            // 
            this.txtnmBanco.Location = new System.Drawing.Point(177, 67);
            this.txtnmBanco.Name = "txtnmBanco";
            this.txtnmBanco.Size = new System.Drawing.Size(100, 20);
            this.txtnmBanco.TabIndex = 17;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(177, 93);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 16;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(283, 203);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(187, 70);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Instancia";
            // 
            // labelporta
            // 
            this.labelporta.AutoSize = true;
            this.labelporta.Location = new System.Drawing.Point(134, 47);
            this.labelporta.Name = "labelporta";
            this.labelporta.Size = new System.Drawing.Size(32, 13);
            this.labelporta.TabIndex = 20;
            this.labelporta.Text = "Porta";
            // 
            // labelbanco
            // 
            this.labelbanco.AutoSize = true;
            this.labelbanco.Location = new System.Drawing.Point(133, 70);
            this.labelbanco.Name = "labelbanco";
            this.labelbanco.Size = new System.Drawing.Size(38, 13);
            this.labelbanco.TabIndex = 21;
            this.labelbanco.Text = "Banco";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(134, 122);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(38, 13);
            this.lblPass.TabIndex = 22;
            this.lblPass.Text = "Senha";
            // 
            // labelinstancia
            // 
            this.labelinstancia.AutoSize = true;
            this.labelinstancia.Location = new System.Drawing.Point(68, 203);
            this.labelinstancia.Name = "labelinstancia";
            this.labelinstancia.Size = new System.Drawing.Size(0, 13);
            this.labelinstancia.TabIndex = 23;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(177, 119);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 24;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(134, 96);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "Teste Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.labelinstancia);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.labelbanco);
            this.Controls.Add(this.labelporta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtnmBanco);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtInstancia);
            this.Controls.Add(this.btnTestar);
            this.Name = "frmconfig";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtnmBanco;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelporta;
        private System.Windows.Forms.Label labelbanco;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label labelinstancia;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button button1;
    }
}

