using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleDeChamados.forms
{
    public partial class frmAdicionarChamado : Form
    {
        public static int count = 0;
        public static string emailCliente;

        public frmAdicionarChamado()
        {
            InitializeComponent();
        }

        private void btnAnexarDesenho_Click(object sender, EventArgs e)
        {
            count++;

            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.Filter = "PDF (*.pdf) |*.pdf| Todos arquivos (*.*)|*.*"; /*"Todos Arquivos (*.*)|*.*";*/
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = true;
            myDialog.CheckFileExists = true;
            myDialog.CheckPathExists = true;
            myDialog.FilterIndex = 1;
            myDialog.RestoreDirectory = true;
            myDialog.ReadOnlyChecked = true;
            myDialog.ShowReadOnly = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (string file in myDialog.FileNames)
                {
                    listBox1.Items.Add(file);
                }
            }
            else
            {
                count = 0;
            }
        }

        private void btnExcluirAnexo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void frmAdicionarChamado_Load(object sender, EventArgs e)
        {
            textBoxUsuario.Text = Environment.UserName;
            dateTimePicker.Text = DateTime.Now.ToString();
            comboBoxPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxUsuario.WordWrap = false;
            verificaemailcliente();
            textBoxEmail.Text = emailCliente;
            
        }

        private void verificaemailcliente()
        {
            Microsoft.Office.Interop.Outlook.Application Application = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.Accounts accounts = Application.Session.Accounts;
            foreach (Microsoft.Office.Interop.Outlook.Account account in accounts)
            {
                emailCliente = account.DisplayName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxPrioridade.Text == "")
            {
                MessageBox.Show("Prioridade vazia! Por favor, Informe-a!");
                comboBoxPrioridade.Focus();
                return;
            }
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo de Email!");
                textBoxEmail.Focus();
                return;
            }
            if (richTextBoxNota.Text == "")
            {
                MessageBox.Show("Informe o motivo da nota!");
                richTextBoxNota.Focus();
                return;
            }

            string query = "Insert into Chamados (nomeUsuario,notas,prioridade,data,email) values ('" + textBoxUsuario.Text + "','" + richTextBoxNota.Text + "', '" + comboBoxPrioridade.Text + "', '" + dateTimePicker.Value.ToShortDateString() + "', '" + textBoxEmail.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, conexao.comunicaBanco);
            if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();

            MessageBox.Show("Nota salva com sucesso!");
            
            //criarDiretorio();
            //enviarEmailCliente();
            //MessageBox.Show("Sua solicitação foi enviada com sucesso ao email". ");


        }
    }
}
