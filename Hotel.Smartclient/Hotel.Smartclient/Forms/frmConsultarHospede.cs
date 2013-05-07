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
    public partial class frmConsultarHospede : Form
    {
        private IHotelFacade hotelFacade;
        private cliente clientePesquisar = null;

        public frmConsultarHospede()
        {
            InitializeComponent();
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public frmConsultarHospede(cliente cliente)
        {
            InitializeComponent();
            this.clientePesquisar = cliente;
            this.dgvClientes.AutoGenerateColumns = false;
            this.hotelFacade = new HotelFacade();
            this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = this.hotelFacade.SelectClientesByNome(this.textBox2.Text);
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clientePesquisar.IdCliente = Int32.Parse(this.dgvClientes[0, e.RowIndex].Value.ToString());
            this.clientePesquisar.NomeCliente = this.dgvClientes[1, e.RowIndex].Value.ToString();
            this.clientePesquisar.TelefoneCliente = this.dgvClientes[3, e.RowIndex].Value.ToString();
            this.clientePesquisar.EmailCliente = this.dgvClientes[4, e.RowIndex].Value.ToString();
            this.Dispose();
        }
    }
}
