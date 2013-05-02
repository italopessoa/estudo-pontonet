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
            IList<cliente> clientes = this.hotelFacade.SelectClientesByNome("Italo");
            this.hotelFacade.RemoveCliente(clientes[0]);
        }
    }
}
