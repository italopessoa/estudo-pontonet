using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotel.Facade;
using Hotel.Facade.Implementation;
using Hotel.Entity;

namespace Hotel.Smartclient.Forms
{
    public partial class frmNovoQuarto : Form
    {
        private IHotelFacade hotelFacade;

        public frmNovoQuarto()
        {
            InitializeComponent();
            this.hotelFacade = new HotelFacade();
            this.carregarTiposQuarto();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string msg = this.validarCamposQuarto();

            if (String.IsNullOrEmpty(msg))
            {
                quarto novoQuarto = new quarto();
                
                novoQuarto.tipo_quarto = this.hotelFacade.SelectTipoQuartoById(((tipo_quarto) this.cmbTipoQuarto.SelectedItem).IdTipoQuarto);
                novoQuarto.PrecoQuarto = Double.Parse(this.txtDiaria.Text);
                try
                {
                    this.hotelFacade.InsertQuarto(novoQuarto);
                    MessageBox.Show("Quarto cadastado com sucesso!", "Operação completada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Quarto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
                MessageBox.Show(msg, "Erro ao cadastrar Quarto.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private string validarCamposQuarto()
        {
            StringBuilder msg = new StringBuilder();

            if (String.IsNullOrEmpty(this.txtDiaria.Text))
                msg.Append("Informe o valor da diária.");
            else
            {
                try
                {
                    double value = Double.Parse(this.txtDiaria.Text);
                }
                catch (Exception ex)
                {
                    msg.Append("Valor de diário inválido!");
                }
            }

            return msg.ToString();
        }

        private void carregarTiposQuarto()
        {
            this.cmbTipoQuarto.DisplayMember = "NomeTipoQuarto";
            this.cmbTipoQuarto.ValueMember = "IdTipoQuarto";
            this.cmbTipoQuarto.DataSource = this.hotelFacade.SelectTiposQuarto();
        }
    }
}
