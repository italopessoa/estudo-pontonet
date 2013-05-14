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
    public partial class frmNovaReserva : Form
    {
        private cliente clienteReserva = new cliente();
        private quarto quartoReserva = new quarto();
        private IList<reserva> reservas = null;
        private IHotelFacade hotelFacade = new HotelFacade();

        public frmNovaReserva()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ListarReservas();
        }
        
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultarHospede consultarHospede = new frmConsultarHospede(this.clienteReserva);
            consultarHospede.ShowDialog();

            if (this.clienteReserva != null)
                this.txtCliente.Text = this.clienteReserva.NomeCliente;
        }

        private void btnBuscarQuarto_Click(object sender, EventArgs e)
        {
            frmConsultarQuarto consultarQuarto = new frmConsultarQuarto(this.quartoReserva);
            consultarQuarto.ShowDialog();

            if (this.quartoReserva.IdQuarto > 0)
                this.textBox1.Text = this.quartoReserva.IdQuarto.ToString();
        }

        private void ListarReservas()
        {
            this.reservas = this.hotelFacade.SelectReservas();
            this.dataGridView1.DataSource = this.reservas;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            reserva novaReserva = new reserva();
            novaReserva.DtEntrada = this.dtpEntrada.Value;
            novaReserva.DtSaida = this.dtpSaida.Value;
            novaReserva.cliente = new cliente() { IdCliente = this.clienteReserva.IdCliente , NomeCliente = this.clienteReserva.NomeCliente};
            novaReserva.quarto = new quarto() { IdQuarto = this.quartoReserva.IdQuarto };
            novaReserva.quarto.tipo_quarto = new tipo_quarto() 
            {
                IdTipoQuarto = this.quartoReserva.tipo_quarto.IdTipoQuarto,
                NomeTipoQuarto = this.quartoReserva.tipo_quarto.NomeTipoQuarto
            };

            this.hotelFacade.InsertReserva(novaReserva);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = this.reservas[e.RowIndex].cliente.NomeCliente;
            }
            else if (e.ColumnIndex == 2)
            {
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = this.reservas[e.RowIndex].quarto.IdQuarto;
            }
        }
    }
}
