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
using Hotel.Smartclient.Utils;

namespace Hotel.Smartclient.Forms
{
    public partial class frmConsultarHospede : Form
    {
        private IHotelFacade hotelFacade;
        private cliente clientePesquisar = null;

        public frmConsultarHospede()
        {
            InitializeComponent();
            //this.dgvClientes.AutoGenerateColumns = false;
            ////this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.hotelFacade = new HotelFacade();
            
            //DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            //editButtonColumn.Text = "Editar";
            ////editButtonColumn.Name = "Editr";
            ////editButtonColumn.DataPropertyName = "Edit";
            //editButtonColumn.UseColumnTextForButtonValue = true;
            //this.dgvClientes.Columns.Add(editButtonColumn);
            ////this.dgvClientes.Columns[2].HeaderText = "Data de Nascimento";
        }

        public frmConsultarHospede(cliente cliente)
        {
            InitializeComponent();
            this.clientePesquisar = cliente;
            //this.hotelFacade = new HotelFacade();
            this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = this.hotelFacade.SelectClientesByNome(this.textBox2.Text);
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.clientePesquisar != null)
            {
                this.clientePesquisar.IdCliente = Int32.Parse(this.dgvClientes[0, e.RowIndex].Value.ToString());
                this.clientePesquisar.NomeCliente = this.dgvClientes[1, e.RowIndex].Value.ToString();
                this.clientePesquisar.TelefoneCliente = this.dgvClientes[3, e.RowIndex].Value.ToString();
                this.clientePesquisar.EmailCliente = this.dgvClientes[4, e.RowIndex].Value.ToString();
                this.Dispose();
            }
        }

        private void btnAlterar_Click(int rowIndex)
        {
            try
            {
                cliente clienteAlterar = new cliente();
                clienteAlterar.IdCliente = Int32.Parse(this.dgvClientes[0, rowIndex].Value.ToString());
                clienteAlterar.NomeCliente = this.dgvClientes[1, rowIndex].Value.ToString();
                clienteAlterar.DtNascimento = DateTime.Parse(this.dgvClientes[2, rowIndex].Value.ToString());
                clienteAlterar.TelefoneCliente = this.dgvClientes[3, rowIndex].Value.ToString();
                clienteAlterar.EmailCliente = this.dgvClientes[4, rowIndex].Value.ToString();

                this.hotelFacade.UpdateCliente(clienteAlterar);
                MessageBox.Show("Dados do cliente alterados com sucesso!", "Operação completada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                this.btnAlterar_Click(e.RowIndex);
            }
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && this.clientePesquisar != null)
            {
                DataGridViewColumn column = this.dgvClientes.Columns[2];
                column.ReadOnly = true;
                column.DataPropertyName = "Idade";
            }
        }

        private void frmConsultarHospede_Load(object sender, EventArgs e)
        {
            this.dgvClientes.AutoGenerateColumns = false;
            this.hotelFacade = new HotelFacade();

            if (this.clientePesquisar == null)
            {
                DataGridViewColumn column = this.dgvClientes.Columns[2];
                column.ReadOnly = false;
                CalendarColumn calendarColumn = new CalendarColumn();
                calendarColumn.DataPropertyName = "DtNascimento";
                this.dgvClientes.Columns.Remove(column);
                calendarColumn.HeaderText = "Data de Nascimento";
                this.dgvClientes.Columns.Insert(2, calendarColumn);

                this.dgvClientes.Columns[1].ReadOnly = false;
                //this.dgvClientes.Columns[2].ReadOnly = false;
                this.dgvClientes.Columns[3].ReadOnly = false;
                this.dgvClientes.Columns[4].ReadOnly = false;

                
                //this.dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Text = "Editar";
                //editButtonColumn.Name = "Editr";
                //editButtonColumn.DataPropertyName = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                this.dgvClientes.Columns.Add(editButtonColumn);
                //this.dgvClientes.Columns[2].HeaderText = "Data de Nascimento";
            }
        }
    }
}

