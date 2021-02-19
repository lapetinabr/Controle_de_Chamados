using controleDeChamados.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleDeChamados
{
    public partial class frmMenu : Form
    {
        //private int childFormNumber = 0;

        public frmMenu()
        {
            InitializeComponent();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Histórico de Chamado")
            {
                frmHistoricoChamado _frmHistoricoChamado = new frmHistoricoChamado();

                _frmHistoricoChamado.Name = "frmInserirChamado";
                _frmHistoricoChamado.Tag = "frmInserirChamado";
                _frmHistoricoChamado.MdiParent = this;
                _frmHistoricoChamado.Show();
            }
            else if (treeView1.SelectedNode.Text == "Adicionar Chamado")
            {
                frmAdicionarChamado _frmAdicionarChamado = new frmAdicionarChamado();
                _frmAdicionarChamado.Name = "frmAdicionarChamado";
                _frmAdicionarChamado.Tag = "frmAdicionarChamado";
                _frmAdicionarChamado.MdiParent = this;
                _frmAdicionarChamado.Show();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
