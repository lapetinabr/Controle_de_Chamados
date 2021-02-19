namespace controleDeChamados.forms
{
    partial class frmAdicionarChamado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcluirAnexo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAnexarDesenho = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxNota = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prioridade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Urgente",
            "Alta",
            "Baixa"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(7, 123);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPrioridade.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(7, 61);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(121, 26);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnExcluirAnexo);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnAnexarDesenho);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.richTextBoxNota);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxPrioridade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 468);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocorrência";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(157, 61);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(255, 26);
            this.textBoxEmail.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "E-mail";
            // 
            // btnExcluirAnexo
            // 
            this.btnExcluirAnexo.Location = new System.Drawing.Point(630, 210);
            this.btnExcluirAnexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluirAnexo.Name = "btnExcluirAnexo";
            this.btnExcluirAnexo.Size = new System.Drawing.Size(130, 35);
            this.btnExcluirAnexo.TabIndex = 33;
            this.btnExcluirAnexo.Text = "Excluir anexo";
            this.btnExcluirAnexo.UseVisualStyleBackColor = true;
            this.btnExcluirAnexo.Click += new System.EventHandler(this.btnExcluirAnexo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(459, 96);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 104);
            this.listBox1.TabIndex = 32;
            // 
            // btnAnexarDesenho
            // 
            this.btnAnexarDesenho.Location = new System.Drawing.Point(459, 50);
            this.btnAnexarDesenho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnexarDesenho.Name = "btnAnexarDesenho";
            this.btnAnexarDesenho.Size = new System.Drawing.Size(302, 37);
            this.btnAnexarDesenho.TabIndex = 31;
            this.btnAnexarDesenho.Text = "Anexar Imagem ou Arquivo";
            this.btnAnexarDesenho.UseVisualStyleBackColor = true;
            this.btnAnexarDesenho.Click += new System.EventHandler(this.btnAnexarDesenho_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(680, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxNota
            // 
            this.richTextBoxNota.Location = new System.Drawing.Point(7, 259);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(375, 140);
            this.richTextBoxNota.TabIndex = 7;
            this.richTextBoxNota.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(7, 197);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(339, 26);
            this.dateTimePicker.TabIndex = 6;
            // 
            // frmAdicionarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 492);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAdicionarChamado";
            this.Text = "Cadastro de Chamados";
            this.Load += new System.EventHandler(this.frmAdicionarChamado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluirAnexo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAnexarDesenho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxNota;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}