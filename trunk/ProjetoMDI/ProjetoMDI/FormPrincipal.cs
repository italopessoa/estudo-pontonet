using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnuAbrirFilho1_Click(object sender, EventArgs e)
        {
            FormFilho1 form = new FormFilho1();
            //form.MdiParent = this;
            form.Show();
        }

        private void mnuAbrirFilho2_Click(object sender, EventArgs e)
        {
            FormFilho2 form = new FormFilho2();
            //form.MdiParent = this;
            form.Show();
        }

        private void mnuAbrirFilho3_Click(object sender, EventArgs e)
        {
            FormFilho3 form = new FormFilho3();
            //form.MdiParent = this;
            form.Show();
        }

        private void mnuCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
        this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuIconesMinimizados_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Text = "Novo Texto";
            }
        }

        private void ativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Text = "Novo Texto 2";
        }
    }
}
