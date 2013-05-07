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
    public partial class frmConsultarQuarto : Form
    {
        private quarto quartoReserva = null;
        private IHotelFacade hotelFacade = new HotelFacade();

        public frmConsultarQuarto()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AutoGenerateColumns = false;
        }

        public frmConsultarQuarto(quarto quartoReserva)
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AutoGenerateColumns = false;
            this.quartoReserva = quartoReserva;
            this.carregarTiposQuarto();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("O valor da diária deve ser maior que o informado?", "Valor diária.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            bool compararMaior = false;
            
            if(res != DialogResult.Cancel){
                if (res == DialogResult.Yes)
                compararMaior = true;
                this.dataGridView1.DataSource = this.hotelFacade.SelectQuartoByTipoQuartoOrPreco(((tipo_quarto) this.cmbTipoQuarto.SelectedItem),double.Parse(this.txtPreco.Text), compararMaior);
            }
        }

        private void carregarTiposQuarto()
        {
            this.cmbTipoQuarto.DisplayMember = "NomeTipoQuarto";
            this.cmbTipoQuarto.ValueMember = "IdTipoQuarto";
            this.cmbTipoQuarto.DataSource = this.hotelFacade.SelectTiposQuarto();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.quartoReserva.IdQuarto = Int32.Parse(this.dataGridView1[0, e.RowIndex].Value.ToString());
            this.quartoReserva.tipo_quarto = new tipo_quarto();
            this.quartoReserva.tipo_quarto.IdTipoQuarto = Int32.Parse(this.dataGridView1[2, e.RowIndex].Value.ToString());
            this.quartoReserva.tipo_quarto.NomeTipoQuarto = this.dataGridView1[1, e.RowIndex].Value.ToString();
            this.Dispose();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dataGridView1[1, e.RowIndex].Value = ((tipo_quarto)this.cmbTipoQuarto.SelectedItem).NomeTipoQuarto;
            this.dataGridView1[2, e.RowIndex].Value = this.cmbTipoQuarto.SelectedValue;
        }
    }
}
