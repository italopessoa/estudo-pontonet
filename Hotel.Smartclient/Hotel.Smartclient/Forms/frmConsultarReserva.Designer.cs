namespace Hotel.Smartclient.Forms
{
    partial class frmConsultarReserva
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
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoQuarto = new System.Windows.Forms.ComboBox();
            this.lblIdQuarto = new System.Windows.Forms.Label();
            this.txtIdQuarto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hospede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtIdQuarto);
            this.groupBox1.Controls.Add(this.lblIdQuarto);
            this.groupBox1.Controls.Add(this.cmbTipoQuarto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDtCadastro);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtReserva);
            this.groupBox1.Controls.Add(this.lblIdReserva);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da reserva";
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.Location = new System.Drawing.Point(7, 20);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(21, 13);
            this.lblIdReserva.TabIndex = 0;
            this.lblIdReserva.Text = "ID:";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(34, 17);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(28, 20);
            this.txtReserva.TabIndex = 1;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(78, 41);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(41, 20);
            this.txtIdCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Hóspede:";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Location = new System.Drawing.Point(161, 20);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(86, 13);
            this.lblDtCadastro.TabIndex = 4;
            this.lblDtCadastro.Text = "Data da reserva:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de quarto:";
            // 
            // cmbTipoQuarto
            // 
            this.cmbTipoQuarto.FormattingEnabled = true;
            this.cmbTipoQuarto.Location = new System.Drawing.Point(253, 41);
            this.cmbTipoQuarto.Name = "cmbTipoQuarto";
            this.cmbTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoQuarto.TabIndex = 7;
            // 
            // lblIdQuarto
            // 
            this.lblIdQuarto.AutoSize = true;
            this.lblIdQuarto.Location = new System.Drawing.Point(7, 74);
            this.lblIdQuarto.Name = "lblIdQuarto";
            this.lblIdQuarto.Size = new System.Drawing.Size(56, 13);
            this.lblIdQuarto.TabIndex = 8;
            this.lblIdQuarto.Text = "ID Quarto:";
            // 
            // txtIdQuarto
            // 
            this.txtIdQuarto.Location = new System.Drawing.Point(78, 71);
            this.txtIdQuarto.Name = "txtIdQuarto";
            this.txtIdQuarto.Size = new System.Drawing.Size(41, 20);
            this.txtIdQuarto.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(212, 97);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Quarto,
            this.Hospede,
            this.DataCadastro,
            this.DataEntrada,
            this.DataSaida});
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(506, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Quarto
            // 
            this.Quarto.HeaderText = "Quarto";
            this.Quarto.Name = "Quarto";
            this.Quarto.Width = 50;
            // 
            // Hospede
            // 
            this.Hospede.HeaderText = "Hóspede";
            this.Hospede.Name = "Hospede";
            this.Hospede.Width = 60;
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "Data de cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Width = 115;
            // 
            // DataEntrada
            // 
            this.DataEntrada.HeaderText = "Data de entrada";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.Width = 110;
            // 
            // DataSaida
            // 
            this.DataSaida.HeaderText = "Data de saída";
            this.DataSaida.Name = "DataSaida";
            // 
            // frmConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 321);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label lblIdReserva;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoQuarto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtIdQuarto;
        private System.Windows.Forms.Label lblIdQuarto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hospede;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaida;
    }
}