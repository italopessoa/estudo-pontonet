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
        private IList<tipo_quarto> tiposQuarto = null;
        private IHotelFacade hotelFacade = new HotelFacade();

        public frmConsultarQuarto()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        public frmConsultarQuarto(quarto quartoReserva)
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.quartoReserva = quartoReserva;
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
            this.tiposQuarto = this.hotelFacade.SelectTiposQuarto();
            this.cmbTipoQuarto.DataSource = this.tiposQuarto;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.quartoReserva != null)
            {
                this.quartoReserva.IdQuarto = Int32.Parse(this.dataGridView1[0, e.RowIndex].Value.ToString());
                this.quartoReserva.tipo_quarto = new tipo_quarto();
                this.quartoReserva.tipo_quarto.IdTipoQuarto = Int32.Parse(this.dataGridView1[2, e.RowIndex].Value.ToString());
                this.quartoReserva.tipo_quarto.NomeTipoQuarto = this.dataGridView1[1, e.RowIndex].Value.ToString();
                this.Dispose();
            }
        }

        private void frmConsultarQuarto_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.hotelFacade = new HotelFacade();
            this.carregarTiposQuarto();
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;

            if (this.quartoReserva == null)
            {
                DataGridViewColumn columnIdTipoQuarto = this.dataGridView1.Columns[1];
                DataGridViewColumn columnNomeTipoQuarto = this.dataGridView1.Columns[2];
                columnNomeTipoQuarto.HeaderText = "Tipo quarto atual";
                DataGridViewComboBoxColumn comboboxColumn = new DataGridViewComboBoxColumn();
                
                this.dataGridView1.Columns.Remove(columnIdTipoQuarto);
                
                //this.dataGridView1.Columns.Remove(columnNomeTipoQuarto);
                comboboxColumn.ReadOnly = false;
                comboboxColumn.DisplayMember = "NomeTipoQuarto";
                comboboxColumn.ValueMember = "IdTipoQuarto";
                comboboxColumn.HeaderText = "Novo Tipo de Quarto";
                comboboxColumn.ToolTipText = comboboxColumn.ValueMember;

                List<tipo_quarto> copyList = new List<tipo_quarto>();
                copyList.AddRange(this.tiposQuarto);

                comboboxColumn.DataSource = copyList;

                this.dataGridView1.Columns.Insert(1, comboboxColumn);
                this.dataGridView1.Columns[1].ReadOnly = false;
                this.dataGridView1.Columns[2].ReadOnly = true;
                this.dataGridView1.Columns[3].ReadOnly = false;

                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Text = "Editar";
                editButtonColumn.UseColumnTextForButtonValue = true;
                
                this.dataGridView1.Columns.Add(editButtonColumn);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && this.quartoReserva != null)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (row.Cells[1].Value == null)
                    row.Cells[1].Value = ((tipo_quarto)this.cmbTipoQuarto.SelectedItem).NomeTipoQuarto;

                if (row.Cells[2].Value == null)
                    row.Cells[2].Value = ((tipo_quarto)this.cmbTipoQuarto.SelectedItem).IdTipoQuarto;
            }
            else if(e.ColumnIndex == 1 && this.quartoReserva == null)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (row.Cells[2].Value == null)
                    row.Cells[2].Value = ((tipo_quarto)this.cmbTipoQuarto.SelectedItem).NomeTipoQuarto;
            }
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (this.quartoReserva != null && e.Column.Index == 1)
            {
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.btnAlterar_Click(e.RowIndex);
            }
        }

        private void btnAlterar_Click(int rowIndex)
        {
            try
            {
                quarto quartoAlterar = new quarto();
                quartoAlterar.IdQuarto = Int32.Parse(this.dataGridView1[0, rowIndex].Value.ToString());
                quartoAlterar.PrecoQuarto = Double.Parse(this.dataGridView1[3, rowIndex].Value.ToString());
                quartoAlterar.tipo_quarto = new tipo_quarto();
                quartoAlterar.tipo_quarto.IdTipoQuarto = (int)this.dataGridView1.Rows[rowIndex].Cells[1].Value;
                quartoAlterar.tipo_quarto.NomeTipoQuarto =
                    this.tiposQuarto[this.tiposQuarto.IndexOf(quartoAlterar.tipo_quarto)].NomeTipoQuarto;
                quartoAlterar.tipo_quarto.DtCadastro =
                    this.tiposQuarto[this.tiposQuarto.IndexOf(quartoAlterar.tipo_quarto)].DtCadastro;

                this.hotelFacade.UpdateQuarto(quartoAlterar);
                MessageBox.Show("Dados do cliente alterados com sucesso!", "Operação completada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Selecione um Tipo de Quarto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
