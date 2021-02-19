namespace controleDeChamados
{
    partial class frmHistoricoChamado
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
            this.dataGridViewInserirChamado = new System.Windows.Forms.DataGridView();
            this.btnExcluirChamado = new System.Windows.Forms.Button();
            this.textBoxNumeroNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInserirChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInserirChamado
            // 
            this.dataGridViewInserirChamado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInserirChamado.Location = new System.Drawing.Point(10, 64);
            this.dataGridViewInserirChamado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInserirChamado.Name = "dataGridViewInserirChamado";
            this.dataGridViewInserirChamado.ReadOnly = true;
            this.dataGridViewInserirChamado.RowHeadersWidth = 62;
            this.dataGridViewInserirChamado.Size = new System.Drawing.Size(1002, 579);
            this.dataGridViewInserirChamado.TabIndex = 0;
            // 
            // btnExcluirChamado
            // 
            this.btnExcluirChamado.Location = new System.Drawing.Point(888, 22);
            this.btnExcluirChamado.Name = "btnExcluirChamado";
            this.btnExcluirChamado.Size = new System.Drawing.Size(124, 36);
            this.btnExcluirChamado.TabIndex = 1;
            this.btnExcluirChamado.Text = "Excluir";
            this.btnExcluirChamado.UseVisualStyleBackColor = true;
            this.btnExcluirChamado.Click += new System.EventHandler(this.btnExcluirChamado_Click);
            // 
            // textBoxNumeroNota
            // 
            this.textBoxNumeroNota.Location = new System.Drawing.Point(767, 27);
            this.textBoxNumeroNota.Name = "textBoxNumeroNota";
            this.textBoxNumeroNota.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumeroNota.TabIndex = 2;
            this.textBoxNumeroNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroNota_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número da Nota que queira excluir:";
            // 
            // frmHistoricoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumeroNota);
            this.Controls.Add(this.btnExcluirChamado);
            this.Controls.Add(this.dataGridViewInserirChamado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmHistoricoChamado";
            this.Text = "Controle de Chamados 1.0v";
            this.Load += new System.EventHandler(this.frmInserirChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInserirChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInserirChamado;
        private System.Windows.Forms.Button btnExcluirChamado;
        private System.Windows.Forms.TextBox textBoxNumeroNota;
        private System.Windows.Forms.Label label1;
    }
}

