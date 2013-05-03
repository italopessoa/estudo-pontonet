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
            tipo_quarto tipoQuarto = new tipo_quarto();
            tipoQuarto.NomeTipoQuarto = txtNome.Text;
            this.hotelFacade.InsertTipoQuarto(tipoQuarto);
        }
    }
}
