namespace Hotel.Smartclient.Forms
{
    partial class frmNovaReserva
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarQuarto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.lblDtEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReservar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReservar);
            this.groupBox1.Controls.Add(this.dtpSaida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpEntrada);
            this.groupBox1.Controls.Add(this.lblDtEntrada);
            this.groupBox1.Controls.Add(this.btnBuscarQuarto);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblQuarto);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da reserva";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(7, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Hóspede:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(63, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(166, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(245, 25);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarQuarto
            // 
            this.btnBuscarQuarto.Location = new System.Drawing.Point(245, 54);
            this.btnBuscarQuarto.Name = "btnBuscarQuarto";
            this.btnBuscarQuarto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarQuarto.TabIndex = 5;
            this.btnBuscarQuarto.Text = "Buscar";
            this.btnBuscarQuarto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(63, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Location = new System.Drawing.Point(7, 59);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(42, 13);
            this.lblQuarto.TabIndex = 3;
            this.lblQuarto.Text = "Quarto:";
            // 
            // lblDtEntrada
            // 
            this.lblDtEntrada.AutoSize = true;
            this.lblDtEntrada.Location = new System.Drawing.Point(7, 93);
            this.lblDtEntrada.Name = "lblDtEntrada";
            this.lblDtEntrada.Size = new System.Drawing.Size(21, 13);
            this.lblDtEntrada.TabIndex = 6;
            this.lblDtEntrada.Text = "De";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(34, 91);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(107, 20);
            this.dtpEntrada.TabIndex = 7;
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaida.Location = new System.Drawing.Point(166, 91);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(107, 20);
            this.dtpSaida.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "à";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.Quarto,
            this.DtEntrada,
            this.DtSaida,
            this.DtCadastro});
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(510, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(184, 126);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 45;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Hóspede";
            this.Cliente.Name = "Cliente";
            // 
            // Quarto
            // 
            this.Quarto.HeaderText = "Quarto";
            this.Quarto.Name = "Quarto";
            this.Quarto.Width = 70;
            // 
            // DtEntrada
            // 
            this.DtEntrada.HeaderText = "Data de entrada";
            this.DtEntrada.Name = "DtEntrada";
            this.DtEntrada.Width = 120;
            // 
            // DtSaida
            // 
            this.DtSaida.HeaderText = "Data de saída";
            this.DtSaida.Name = "DtSaida";
            // 
            // DtCadastro
            // 
            this.DtCadastro.HeaderText = "Data de reserva";
            this.DtCadastro.Name = "DtCadastro";
            this.DtCadastro.Width = 120;
            // 
            // frmNovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblDtEntrada;
        private System.Windows.Forms.Button btnBuscarQuarto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtCadastro;

    }
}