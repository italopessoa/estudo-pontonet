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
    public partial class frmConsultarReserva : Form
    {
        private IList<reserva> reservas = null;
        private IHotelFacade hotelFacade = null;

        public frmConsultarReserva()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
                {
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = this.reservas[e.RowIndex].cliente.NomeCliente;
                }
            }
            else if (e.ColumnIndex == 2)
            {
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
                {
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = this.reservas[e.RowIndex].quarto.IdQuarto;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.carregarReservas();
            this.dataGridView1.DataSource = this.reservas;
        }

        private void carregarReservas()
        {
            cliente clienteReserva = null;
            quarto quartoReserva = null;
            clienteReserva = new cliente();
            clienteReserva.IdCliente = Int32.Parse(this.cmbClientes.SelectedValue.ToString());
            quartoReserva = new quarto();
            quartoReserva.IdQuarto = Int32.Parse(this.cmbQuartos.SelectedValue.ToString());

            this.reservas = this.hotelFacade.SelectReservaByClienteOrQuarto(clienteReserva, quartoReserva);
        }

        private void frmConsultarReserva_Load(object sender, EventArgs e)
        {
            this.hotelFacade = new HotelFacade();
            this.dataGridView1.AutoGenerateColumns = false;

            this.cmbClientes.DisplayMember = "NomeCliente";
            this.cmbClientes.ValueMember = "IdCliente";
            this.cmbClientes.DataSource = this.hotelFacade.SelectClientes();

            this.cmbQuartos.DisplayMember = "IdQuarto";
            this.cmbQuartos.ValueMember = "IdQuarto";
            this.cmbQuartos.DataSource = this.hotelFacade.SelectQuartos();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                this.btnAlterar_Click(e.RowIndex);
            }
            else if (e.ColumnIndex == 7)
            {
                this.btnExcluir_Click(e.RowIndex);
            }
        }

        private void btnAlterar_Click(int p)
        {
            throw new NotImplementedException();
        }

        private void btnExcluir_Click(int p)
        {
            reserva reservaExcluir = new reserva();
            reservaExcluir.IdReserva = Int32.Parse(this.dataGridView1[0, p].Value.ToString());
            try
            {
                this.hotelFacade.RemoveReserva(reservaExcluir);
                this.carregarReservas();
            }
            catch (Exception ex)
            {
            }
            
        }
    }
}
