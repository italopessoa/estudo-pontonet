using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel.Smartclient.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void hospedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new frmNovoCliente().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?","Sair",MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new frmConsultarHospede().ShowDialog();
        }

        private void reservaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = new frmConsultarReserva().ShowDialog();
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = new frmConsultarQuarto().ShowDialog();
        }

        private void novoQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new frmNovoQuarto().ShowDialog();
        }

        private void tipoDeQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new frmNovoTipoQuarto().ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new frmNovaReserva().ShowDialog();
        }
    }
}
