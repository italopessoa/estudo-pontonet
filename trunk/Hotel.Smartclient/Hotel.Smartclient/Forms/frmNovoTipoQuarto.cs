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
    public partial class frmNovoTipoQuarto : Form
    {
        private IHotelFacade hotelFacade;

        public frmNovoTipoQuarto()
        {
            InitializeComponent();
            this.hotelFacade = new HotelFacade();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string msg = this.validarCamposTipoQuarto();
            if (String.IsNullOrEmpty(msg))
            {
                tipo_quarto tipoQuarto = new tipo_quarto();
                tipoQuarto.NomeTipoQuarto = txtNome.Text;
                try
                {
                    this.hotelFacade.InsertTipoQuarto(tipoQuarto);
                    MessageBox.Show("Tipo de Quarto cadastado com sucesso!", "Operação completada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Tipo de Quarto.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
                MessageBox.Show(msg, "Erro ao cadastrar Tipo de Quarto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string validarCamposTipoQuarto()
        {
            StringBuilder msg = new StringBuilder();
            if (String.IsNullOrEmpty(this.txtNome.Text))
            {
                msg.Append("Informe o nome do Tipo de Quarto.");
            }

            return msg.ToString();
        }
    }
}
