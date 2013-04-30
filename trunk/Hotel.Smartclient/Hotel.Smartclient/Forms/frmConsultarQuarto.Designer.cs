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
            this.lblIdQuarto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipoQuarto = new System.Windows.Forms.Label();
            this.cmbTipoQuarto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cmbTipoQuarto);
            this.groupBox1.Controls.Add(this.lblTipoQuarto);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblIdQuarto);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do quarto";
            // 
            // lblIdQuarto
            // 
            this.lblIdQuarto.AutoSize = true;
            this.lblIdQuarto.Location = new System.Drawing.Point(7, 20);
            this.lblIdQuarto.Name = "lblIdQuarto";
            this.lblIdQuarto.Size = new System.Drawing.Size(56, 13);
            this.lblIdQuarto.TabIndex = 0;
            this.lblIdQuarto.Text = "ID Quarto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 1;
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
            // cmbTipoQuarto
            // 
            this.cmbTipoQuarto.FormattingEnabled = true;
            this.cmbTipoQuarto.Location = new System.Drawing.Point(222, 17);
            this.cmbTipoQuarto.Name = "cmbTipoQuarto";
            this.cmbTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoQuarto.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tipo,
            this.Valor,
            this.DtCadastro});
            this.dataGridView1.Location = new System.Drawing.Point(13, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(400, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // DtCadastro
            // 
            this.DtCadastro.HeaderText = "Data de cadastro";
            this.DtCadastro.Name = "DtCadastro";
            this.DtCadastro.Width = 120;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(141, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // frmConsultarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 292);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIdQuarto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtCadastro;
    }
}