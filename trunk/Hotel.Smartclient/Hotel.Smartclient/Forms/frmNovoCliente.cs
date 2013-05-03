using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotel.Entity;
using Hotel.Facade;
using Hotel.Facade.Implementation;

namespace Hotel.Smartclient.Forms
{
    public partial class frmNovoCliente : Form
    {
        private IHotelFacade hotelFacade;
        public frmNovoCliente()
        {
            InitializeComponent();
            this.hotelFacade = new HotelFacade();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string msg = this.validarCamposCliente();
            if (String.IsNullOrEmpty(msg))
            {
                cliente novoCliente = new cliente();
                novoCliente.NomeCliente = this.txtNome.Text;
                novoCliente.TelefoneCliente = this.txtFone.Text;
                novoCliente.EmailCliente = this.txtEmail.Text;
                novoCliente.DtNascimento = this.dateTimePicker1.Value;
                try
                {
                    this.hotelFacade.InsertCliente(novoCliente);
                    MessageBox.Show("Cliente cadastado com sucesso!", "Operação completada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(msg, "Erro ao cadastrar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private string validarCamposCliente()
        {
            StringBuilder msg = new StringBuilder();
            if (String.IsNullOrEmpty(this.txtNome.Text))
                msg.Append("Informe o nome do cliente.");

            return msg.ToString();
        }
    }
}
