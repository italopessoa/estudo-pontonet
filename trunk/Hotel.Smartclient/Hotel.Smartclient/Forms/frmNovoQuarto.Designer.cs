namespace Hotel.Smartclient.Forms
{
    partial class frmNovoQuarto
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbTipoQuarto = new System.Windows.Forms.ComboBox();
            this.lblTipoQuarto = new System.Windows.Forms.Label();
            this.txtDiaria = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.cmbTipoQuarto);
            this.groupBox1.Controls.Add(this.lblTipoQuarto);
            this.groupBox1.Controls.Add(this.txtDiaria);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do quarto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(140, 58);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbTipoQuarto
            // 
            this.cmbTipoQuarto.FormattingEnabled = true;
            this.cmbTipoQuarto.Location = new System.Drawing.Point(232, 19);
            this.cmbTipoQuarto.Name = "cmbTipoQuarto";
            this.cmbTipoQuarto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoQuarto.TabIndex = 3;
            // 
            // lblTipoQuarto
            // 
            this.lblTipoQuarto.AutoSize = true;
            this.lblTipoQuarto.Location = new System.Drawing.Point(147, 20);
            this.lblTipoQuarto.Name = "lblTipoQuarto";
            this.lblTipoQuarto.Size = new System.Drawing.Size(79, 13);
            this.lblTipoQuarto.TabIndex = 2;
            this.lblTipoQuarto.Text = "Tipo de quarto:";
            // 
            // txtDiaria
            // 
            this.txtDiaria.Location = new System.Drawing.Point(51, 20);
            this.txtDiaria.Name = "txtDiaria";
            this.txtDiaria.Size = new System.Drawing.Size(78, 20);
            this.txtDiaria.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(7, 20);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Diária:";
            // 
            // frmNovoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 131);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovoQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo quarto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbTipoQuarto;
        private System.Windows.Forms.Label lblTipoQuarto;
        private System.Windows.Forms.TextBox txtDiaria;
    }
}