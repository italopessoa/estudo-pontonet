namespace Hotel.Smartclient.Forms
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospedeToolStripMenuItem,
            this.quartoToolStripMenuItem,
            this.reservaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.cadastroToolStripMenuItem.Text = "Novo";
            // 
            // hospedeToolStripMenuItem
            // 
            this.hospedeToolStripMenuItem.Name = "hospedeToolStripMenuItem";
            this.hospedeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hospedeToolStripMenuItem.Text = "Hospede";
            this.hospedeToolStripMenuItem.Click += new System.EventHandler(this.hospedeToolStripMenuItem_Click);
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoQuartoToolStripMenuItem,
            this.tipoDeQuartoToolStripMenuItem});
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quartoToolStripMenuItem.Text = "Quarto";
            // 
            // novoQuartoToolStripMenuItem
            // 
            this.novoQuartoToolStripMenuItem.Name = "novoQuartoToolStripMenuItem";
            this.novoQuartoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.novoQuartoToolStripMenuItem.Text = "Novo Quarto";
            this.novoQuartoToolStripMenuItem.Click += new System.EventHandler(this.novoQuartoToolStripMenuItem_Click);
            // 
            // tipoDeQuartoToolStripMenuItem
            // 
            this.tipoDeQuartoToolStripMenuItem.Name = "tipoDeQuartoToolStripMenuItem";
            this.tipoDeQuartoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.tipoDeQuartoToolStripMenuItem.Text = "Tipo de Quarto";
            this.tipoDeQuartoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeQuartoToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reservaToolStripMenuItem.Text = "Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospedeToolStripMenuItem1,
            this.quartoToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // hospedeToolStripMenuItem1
            // 
            this.hospedeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.reservaToolStripMenuItem1});
            this.hospedeToolStripMenuItem1.Name = "hospedeToolStripMenuItem1";
            this.hospedeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.hospedeToolStripMenuItem1.Text = "Hospede";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dadosToolStripMenuItem.Text = "Dados";
            this.dadosToolStripMenuItem.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem1
            // 
            this.reservaToolStripMenuItem1.Name = "reservaToolStripMenuItem1";
            this.reservaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.reservaToolStripMenuItem1.Text = "Reserva";
            this.reservaToolStripMenuItem1.Click += new System.EventHandler(this.reservaToolStripMenuItem1_Click);
            // 
            // quartoToolStripMenuItem1
            // 
            this.quartoToolStripMenuItem1.Name = "quartoToolStripMenuItem1";
            this.quartoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quartoToolStripMenuItem1.Text = "Quarto";
            this.quartoToolStripMenuItem1.Click += new System.EventHandler(this.quartoToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "tsslStatus";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospedagem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoQuartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeQuartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;


    }
}

