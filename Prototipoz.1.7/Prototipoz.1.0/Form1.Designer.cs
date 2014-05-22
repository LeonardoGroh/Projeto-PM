namespace Prototipoz._1._0
{
    partial class Menu
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
            this.funcionarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAnimalMenuF = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEspécieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAnimalMenuA = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEspécieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarRecintoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcionarioMenu
            // 
            this.funcionarioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAnimalMenuF,
            this.cadastrarEspécieToolStripMenuItem});
            this.funcionarioMenu.Name = "funcionarioMenu";
            this.funcionarioMenu.Size = new System.Drawing.Size(61, 20);
            this.funcionarioMenu.Text = "Técnico";
            // 
            // cadastrarAnimalMenuF
            // 
            this.cadastrarAnimalMenuF.Name = "cadastrarAnimalMenuF";
            this.cadastrarAnimalMenuF.Size = new System.Drawing.Size(166, 22);
            this.cadastrarAnimalMenuF.Text = "Cadastrar Animal";
            this.cadastrarAnimalMenuF.Click += new System.EventHandler(this.cadastrarAnimalMenuF_Click);
            // 
            // cadastrarEspécieToolStripMenuItem
            // 
            this.cadastrarEspécieToolStripMenuItem.Name = "cadastrarEspécieToolStripMenuItem";
            this.cadastrarEspécieToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cadastrarEspécieToolStripMenuItem.Text = "Cadastrar Espécie";
            this.cadastrarEspécieToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEspécieToolStripMenuItem_Click);
            // 
            // administradorMenu
            // 
            this.administradorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAnimalMenuA,
            this.cadastrarEspécieToolStripMenuItem1,
            this.cadastrarRecintoMenu,
            this.cadastrarFuncionarioMenu});
            this.administradorMenu.Name = "administradorMenu";
            this.administradorMenu.Size = new System.Drawing.Size(95, 20);
            this.administradorMenu.Text = "Administrador";
            // 
            // cadastrarAnimalMenuA
            // 
            this.cadastrarAnimalMenuA.Name = "cadastrarAnimalMenuA";
            this.cadastrarAnimalMenuA.Size = new System.Drawing.Size(190, 22);
            this.cadastrarAnimalMenuA.Text = "Cadastrar Animal";
            this.cadastrarAnimalMenuA.Click += new System.EventHandler(this.cadastrarAnimalMenuA_Click);
            // 
            // cadastrarEspécieToolStripMenuItem1
            // 
            this.cadastrarEspécieToolStripMenuItem1.Name = "cadastrarEspécieToolStripMenuItem1";
            this.cadastrarEspécieToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.cadastrarEspécieToolStripMenuItem1.Text = "Cadastrar Espécie";
            this.cadastrarEspécieToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarEspécieToolStripMenuItem1_Click);
            // 
            // cadastrarRecintoMenu
            // 
            this.cadastrarRecintoMenu.Name = "cadastrarRecintoMenu";
            this.cadastrarRecintoMenu.Size = new System.Drawing.Size(190, 22);
            this.cadastrarRecintoMenu.Text = "Cadastrar Recinto";
            this.cadastrarRecintoMenu.Click += new System.EventHandler(this.cadastrarRecintoMenu_Click);
            // 
            // cadastrarFuncionarioMenu
            // 
            this.cadastrarFuncionarioMenu.Name = "cadastrarFuncionarioMenu";
            this.cadastrarFuncionarioMenu.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFuncionarioMenu.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionarioMenu.Click += new System.EventHandler(this.cadastrarFuncionarioMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioMenu,
            this.administradorMenu,
            this.userMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userMenu
            // 
            this.userMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(42, 20);
            this.userMenu.Text = "User";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(366, 293);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem funcionarioMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAnimalMenuF;
        private System.Windows.Forms.ToolStripMenuItem administradorMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAnimalMenuA;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionarioMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarRecintoMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEspécieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEspécieToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem userMenu;

    }
}

