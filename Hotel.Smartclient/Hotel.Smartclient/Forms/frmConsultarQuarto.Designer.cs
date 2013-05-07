namespace Hotel.Smartclient.Forms
{
    partial class frmConsultarQuarto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbTipoQuarto = new System.Windows.Forms.ComboBox();
            this.lblTipoQuarto = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPrecoQuarto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cmbTipoQuarto);
            this.groupBox1.Controls.Add(this.lblTipoQuarto);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lblPrecoQuarto);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do quarto";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(141, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbTipoQuarto
            // 
            this.cmbTipoQuarto.FormattingEnabled = true;
            this.cmbTipoQuarto.Location = new System.Drawing.Point(222, 17);
            this.cmbTipoQuarto.Name = "cmbTipoQuarto";
            this.cmbTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoQuarto.TabIndex = 3;
            // 
            // lblTipoQuarto
            // 
            this.lblTipoQuarto.AutoSize = true;
            this.lblTipoQuarto.Location = new System.Drawing.Point(137, 20);
            this.lblTipoQuarto.Name = "lblTipoQuarto";
            this.lblTipoQuarto.Size = new System.Drawing.Size(79, 13);
            this.lblTipoQuarto.TabIndex = 2;
            this.lblTipoQuarto.Text = "Tipo de quarto:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(69, 17);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(38, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // lblPrecoQuarto
            // 
            this.lblPrecoQuarto.AutoSize = true;
            this.lblPrecoQuarto.Location = new System.Drawing.Point(7, 20);
            this.lblPrecoQuarto.Name = "lblPrecoQuarto";
            this.lblPrecoQuarto.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoQuarto.TabIndex = 0;
            this.lblPrecoQuarto.Text = "Preço:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tipo,
            this.Column1,
            this.Valor,
            this.DtCadastro});
            this.dataGridView1.Location = new System.Drawing.Point(13, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(415, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdQuarto";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo_quarto.NomeTipoQuarto";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tipo_quarto.IdTipoQuarto";
            this.Column1.HeaderText = "IdTipoQuarto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "PrecoQuarto";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // DtCadastro
            // 
            this.DtCadastro.DataPropertyName = "DtCadastro";
            this.DtCadastro.HeaderText = "Data de cadastro";
            this.DtCadastro.Name = "DtCadastro";
            this.DtCadastro.ReadOnly = true;
            this.DtCadastro.Width = 120;
            // 
            // frmConsultarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 292);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar quarto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoQuarto;
        private System.Windows.Forms.Label lblTipoQuarto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPrecoQuarto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtCadastro;
    }
}