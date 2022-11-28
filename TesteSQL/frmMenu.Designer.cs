namespace TesteSQL
{
    partial class frmMenu
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
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadUser = new System.Windows.Forms.Button();
            this.btnVerCompras = new System.Windows.Forms.Button();
            this.btnConfigBanco = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Enabled = false;
            this.btnCadProduto.Location = new System.Drawing.Point(46, 38);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(131, 68);
            this.btnCadProduto.TabIndex = 0;
            this.btnCadProduto.Text = "Cadastrar Produtos";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadUser
            // 
            this.btnCadUser.Enabled = false;
            this.btnCadUser.Location = new System.Drawing.Point(291, 38);
            this.btnCadUser.Name = "btnCadUser";
            this.btnCadUser.Size = new System.Drawing.Size(131, 68);
            this.btnCadUser.TabIndex = 1;
            this.btnCadUser.Text = "Cadastrar Usuarios";
            this.btnCadUser.UseVisualStyleBackColor = true;
            this.btnCadUser.Click += new System.EventHandler(this.btnCadUser_Click);
            // 
            // btnVerCompras
            // 
            this.btnVerCompras.Location = new System.Drawing.Point(46, 126);
            this.btnVerCompras.Name = "btnVerCompras";
            this.btnVerCompras.Size = new System.Drawing.Size(131, 68);
            this.btnVerCompras.TabIndex = 2;
            this.btnVerCompras.Text = "Ver Compras";
            this.btnVerCompras.UseVisualStyleBackColor = true;
            this.btnVerCompras.Click += new System.EventHandler(this.btnVerCompras_Click);
            // 
            // btnConfigBanco
            // 
            this.btnConfigBanco.Enabled = false;
            this.btnConfigBanco.Location = new System.Drawing.Point(291, 126);
            this.btnConfigBanco.Name = "btnConfigBanco";
            this.btnConfigBanco.Size = new System.Drawing.Size(131, 68);
            this.btnConfigBanco.TabIndex = 3;
            this.btnConfigBanco.Text = "Configurar Banco";
            this.btnConfigBanco.UseVisualStyleBackColor = true;
            this.btnConfigBanco.Click += new System.EventHandler(this.btnConfigBanco_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.Location = new System.Drawing.Point(169, 302);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(131, 38);
            this.btnDeslogar.TabIndex = 4;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 352);
            this.Controls.Add(this.btnDeslogar);
            this.Controls.Add(this.btnConfigBanco);
            this.Controls.Add(this.btnVerCompras);
            this.Controls.Add(this.btnCadUser);
            this.Controls.Add(this.btnCadProduto);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadUser;
        private System.Windows.Forms.Button btnVerCompras;
        private System.Windows.Forms.Button btnConfigBanco;
        private System.Windows.Forms.Button btnDeslogar;
    }
}