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

namespace controleDeChamados
{
    public partial class frmHistoricoChamado : Form
    {
        DataTable dttConteudo = new DataTable();

        public frmHistoricoChamado()
        {
            InitializeComponent();
        }

        private void frmInserirChamado_Load(object sender, EventArgs e)
        {
            carregarChamados();

            
        }

        private void carregarChamados()
        {
            OleDbCommand cmd = new OleDbCommand("select * from Chamados", conexao.comunicaBanco);
            if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
            dttConteudo.Clear();
            dttConteudo.Load(cmd.ExecuteReader());
            dataGridViewInserirChamado.DataSource = dttConteudo;
            if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();


        }
        private void btnExcluirChamado_Click(object sender, EventArgs e)
        {
            string query = "delete from Chamados where idChamado = " + textBoxNumeroNota.Text + "";
            OleDbCommand cmd = new OleDbCommand(query, conexao.comunicaBanco);       //Função Utilizada para comandos sql
            if (cmd.Connection.State != ConnectionState.Open) { cmd.Connection.Open(); } // abre a conexao que estava registrada
            //cmd.Parameters.AddWithValue("@idChamado", idChamado.ToString());
            cmd.ExecuteNonQuery();

            carregarChamados();
            textBoxNumeroNota.Text = "";

        }

        private void textBoxNumeroNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

        
    }

