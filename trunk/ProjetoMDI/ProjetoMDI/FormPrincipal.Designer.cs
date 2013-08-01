namespace ProjetoMDI
{
    partial class FormPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrirFilho1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrirFilho2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrirFilho3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormsAbertos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIconesMinimizados = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuFormsAbertos,
            this.mnuJanela});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(284, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbrirFilho1,
            this.mnuAbrirFilho2,
            this.mnuAbrirFilho3});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuAbrirFilho1
            // 
            this.mnuAbrirFilho1.Name = "mnuAbrirFilho1";
            this.mnuAbrirFilho1.Size = new System.Drawing.Size(152, 22);
            this.mnuAbrirFilho1.Text = "Abrir Filho 1";
            this.mnuAbrirFilho1.Click += new System.EventHandler(this.mnuAbrirFilho1_Click);
            // 
            // mnuAbrirFilho2
            // 
            this.mnuAbrirFilho2.Name = "mnuAbrirFilho2";
            this.mnuAbrirFilho2.Size = new System.Drawing.Size(152, 22);
            this.mnuAbrirFilho2.Text = "Abrir Filho 2";
            this.mnuAbrirFilho2.Click += new System.EventHandler(this.mnuAbrirFilho2_Click);
            // 
            // mnuAbrirFilho3
            // 
            this.mnuAbrirFilho3.Name = "mnuAbrirFilho3";
            this.mnuAbrirFilho3.Size = new System.Drawing.Size(152, 22);
            this.mnuAbrirFilho3.Text = "Abrir Filho 3";
            this.mnuAbrirFilho3.Click += new System.EventHandler(this.mnuAbrirFilho3_Click);
            // 
            // mnuFormsAbertos
            // 
            this.mnuFormsAbertos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.ativoToolStripMenuItem});
            this.mnuFormsAbertos.Name = "mnuFormsAbertos";
            this.mnuFormsAbertos.Size = new System.Drawing.Size(96, 20);
            this.mnuFormsAbertos.Text = "Forms Abertos";
            // 
            // mnuJanela
            // 
            this.mnuJanela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascata,
            this.mnuHorizontal,
            this.mnuVertical,
            this.mnuIconesMinimizados});
            this.mnuJanela.Name = "mnuJanela";
            this.mnuJanela.Size = new System.Drawing.Size(51, 20);
            this.mnuJanela.Text = "Janela";
            // 
            // mnuCascata
            // 
            this.mnuCascata.Name = "mnuCascata";
            this.mnuCascata.Size = new System.Drawing.Size(191, 22);
            this.mnuCascata.Text = "Cascata";
            this.mnuCascata.Click += new System.EventHandler(this.mnuCascata_Click);
            // 
            // mnuHorizontal
            // 
            this.mnuHorizontal.Name = "mnuHorizontal";
            this.mnuHorizontal.Size = new System.Drawing.Size(191, 22);
            this.mnuHorizontal.Text = "Lado a lado horizontal";
            this.mnuHorizontal.Click += new System.EventHandler(this.mnuHorizontal_Click);
            // 
            // mnuVertical
            // 
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(191, 22);
            this.mnuVertical.Text = "Lado a lado vertical";
            this.mnuVertical.Click += new System.EventHandler(this.mnuVertical_Click);
            // 
            // mnuIconesMinimizados
            // 
            this.mnuIconesMinimizados.Name = "mnuIconesMinimizados";
            this.mnuIconesMinimizados.Size = new System.Drawing.Size(191, 22);
            this.mnuIconesMinimizados.Text = "Ícones minimizados";
            this.mnuIconesMinimizados.Click += new System.EventHandler(this.mnuIconesMinimizados_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // ativoToolStripMenuItem
            // 
            this.ativoToolStripMenuItem.Name = "ativoToolStripMenuItem";
            this.ativoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ativoToolStripMenuItem.Text = "Ativo";
            this.ativoToolStripMenuItem.Click += new System.EventHandler(this.ativoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirFilho1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirFilho2;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirFilho3;
        private System.Windows.Forms.ToolStripMenuItem mnuFormsAbertos;
        private System.Windows.Forms.ToolStripMenuItem mnuJanela;
        private System.Windows.Forms.ToolStripMenuItem mnuCascata;
        private System.Windows.Forms.ToolStripMenuItem mnuHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuIconesMinimizados;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ativoToolStripMenuItem;
    }
}

