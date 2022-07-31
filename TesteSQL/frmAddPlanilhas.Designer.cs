namespace TesteSQL
{
    partial class frmAddPlanilhas
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddplanilha = new System.Windows.Forms.Button();
            this.lblNomePlanilha = new System.Windows.Forms.Label();
            this.btnCarregarPlanilha = new System.Windows.Forms.Button();
            this.btnBaixarPlanilha = new System.Windows.Forms.Button();
            this.dgvDataSouce = new System.Windows.Forms.DataGridView();
            this.btnAttDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSouce)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddplanilha
            // 
            this.btnAddplanilha.Location = new System.Drawing.Point(12, 12);
            this.btnAddplanilha.Name = "btnAddplanilha";
            this.btnAddplanilha.Size = new System.Drawing.Size(172, 59);
            this.btnAddplanilha.TabIndex = 0;
            this.btnAddplanilha.Text = "Adicionar Planilha";
            this.btnAddplanilha.UseVisualStyleBackColor = true;
            this.btnAddplanilha.Click += new System.EventHandler(this.btnAddplanilha_Click);
            // 
            // lblNomePlanilha
            // 
            this.lblNomePlanilha.AutoSize = true;
            this.lblNomePlanilha.Location = new System.Drawing.Point(12, 74);
            this.lblNomePlanilha.Name = "lblNomePlanilha";
            this.lblNomePlanilha.Size = new System.Drawing.Size(89, 13);
            this.lblNomePlanilha.TabIndex = 1;
            this.lblNomePlanilha.Text = "Nome da planilha";
            // 
            // btnCarregarPlanilha
            // 
            this.btnCarregarPlanilha.Location = new System.Drawing.Point(15, 135);
            this.btnCarregarPlanilha.Name = "btnCarregarPlanilha";
            this.btnCarregarPlanilha.Size = new System.Drawing.Size(172, 59);
            this.btnCarregarPlanilha.TabIndex = 2;
            this.btnCarregarPlanilha.Text = "Carregar Planilha";
            this.btnCarregarPlanilha.UseVisualStyleBackColor = true;
            this.btnCarregarPlanilha.Click += new System.EventHandler(this.btnCarregarPlanilha_Click);
            // 
            // btnBaixarPlanilha
            // 
            this.btnBaixarPlanilha.Location = new System.Drawing.Point(15, 210);
            this.btnBaixarPlanilha.Name = "btnBaixarPlanilha";
            this.btnBaixarPlanilha.Size = new System.Drawing.Size(172, 59);
            this.btnBaixarPlanilha.TabIndex = 3;
            this.btnBaixarPlanilha.Text = "Baixar Planilha";
            this.btnBaixarPlanilha.UseVisualStyleBackColor = true;
            this.btnBaixarPlanilha.Click += new System.EventHandler(this.btnBaixarPlanilha_Click);
            // 
            // dgvDataSouce
            // 
            this.dgvDataSouce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSouce.Location = new System.Drawing.Point(228, 12);
            this.dgvDataSouce.Name = "dgvDataSouce";
            this.dgvDataSouce.Size = new System.Drawing.Size(551, 257);
            this.dgvDataSouce.TabIndex = 4;
            // 
            // btnAttDados
            // 
            this.btnAttDados.Location = new System.Drawing.Point(15, 275);
            this.btnAttDados.Name = "btnAttDados";
            this.btnAttDados.Size = new System.Drawing.Size(172, 59);
            this.btnAttDados.TabIndex = 5;
            this.btnAttDados.Text = "Atualizar Dados";
            this.btnAttDados.UseVisualStyleBackColor = true;
            this.btnAttDados.Click += new System.EventHandler(this.btnAttDados_Click);
            // 
            // frmAddPlanilhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.btnAttDados);
            this.Controls.Add(this.dgvDataSouce);
            this.Controls.Add(this.btnBaixarPlanilha);
            this.Controls.Add(this.btnCarregarPlanilha);
            this.Controls.Add(this.lblNomePlanilha);
            this.Controls.Add(this.btnAddplanilha);
            this.Name = "frmAddPlanilhas";
            this.Text = "frmAddPlanilhas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSouce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddplanilha;
        private System.Windows.Forms.Label lblNomePlanilha;
        private System.Windows.Forms.Button btnCarregarPlanilha;
        private System.Windows.Forms.Button btnBaixarPlanilha;
        private System.Windows.Forms.DataGridView dgvDataSouce;
        private System.Windows.Forms.Button btnAttDados;
    }
}