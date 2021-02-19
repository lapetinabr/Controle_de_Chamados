namespace controleDeChamados
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cadastrar Usuário");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Adicionar Chamado");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Histórico de Chamado");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Menu", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.LineColor = System.Drawing.Color.Crimson;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "cadastroUsuario";
            treeNode5.Text = "Cadastrar Usuário";
            treeNode5.ToolTipText = "Casos da";
            treeNode6.Name = "adicionarChamado";
            treeNode6.Text = "Adicionar Chamado";
            treeNode6.ToolTipText = "Casos da Omron";
            treeNode7.Name = "historicoDeChamado";
            treeNode7.Text = "Histórico de Chamado";
            treeNode7.ToolTipText = "Casos da Ns";
            treeNode8.Name = "MenuChamados";
            treeNode8.Text = "Menu";
            treeNode8.ToolTipText = "Requisições  de Clientes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(284, 1008);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_page.png");
            this.imageList1.Images.SetKeyName(1, "accept.png");
            this.imageList1.Images.SetKeyName(2, "application.png");
            this.imageList1.Images.SetKeyName(3, "application_cascade.png");
            this.imageList1.Images.SetKeyName(4, "Cad.png");
            this.imageList1.Images.SetKeyName(5, "calculator_edit.png");
            this.imageList1.Images.SetKeyName(6, "calendar_edit.png");
            this.imageList1.Images.SetKeyName(7, "chart_organisation.png");
            this.imageList1.Images.SetKeyName(8, "Config.png");
            this.imageList1.Images.SetKeyName(9, "Customer.png");
            this.imageList1.Images.SetKeyName(10, "customer-icon.png");
            this.imageList1.Images.SetKeyName(11, "delete.png");
            this.imageList1.Images.SetKeyName(12, "edit.png");
            this.imageList1.Images.SetKeyName(13, "EntryConference.png");
            this.imageList1.Images.SetKeyName(14, "finance2.png");
            this.imageList1.Images.SetKeyName(15, "finance3.png");
            this.imageList1.Images.SetKeyName(16, "find.png");
            this.imageList1.Images.SetKeyName(17, "flag_red.png");
            this.imageList1.Images.SetKeyName(18, "folder.png");
            this.imageList1.Images.SetKeyName(19, "information.png");
            this.imageList1.Images.SetKeyName(20, "InventoryStatus.png");
            this.imageList1.Images.SetKeyName(21, "key.png");
            this.imageList1.Images.SetKeyName(22, "keyboard.png");
            this.imageList1.Images.SetKeyName(23, "login.png");
            this.imageList1.Images.SetKeyName(24, "logo_app.jpg");
            this.imageList1.Images.SetKeyName(25, "logo_app_data.jpg");
            this.imageList1.Images.SetKeyName(26, "logo_app2.jpg");
            this.imageList1.Images.SetKeyName(27, "logo_reports.jpg");
            this.imageList1.Images.SetKeyName(28, "lorry_go.png");
            this.imageList1.Images.SetKeyName(29, "magnifier_zoom_in.png");
            this.imageList1.Images.SetKeyName(30, "money.png");
            this.imageList1.Images.SetKeyName(31, "money_dollar.png");
            this.imageList1.Images.SetKeyName(32, "printer.png");
            this.imageList1.Images.SetKeyName(33, "Product.png");
            this.imageList1.Images.SetKeyName(34, "Transporter.png");
            this.imageList1.Images.SetKeyName(35, "user.png");
            this.imageList1.Images.SetKeyName(36, "users.png");
            this.imageList1.Images.SetKeyName(37, "vcard.png");
            this.imageList1.Images.SetKeyName(38, "Warning.jpg");
            this.imageList1.Images.SetKeyName(39, "workflow.png");
            this.imageList1.Images.SetKeyName(40, "xml.png");
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 1008);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle de Chamados 1.0v";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}



