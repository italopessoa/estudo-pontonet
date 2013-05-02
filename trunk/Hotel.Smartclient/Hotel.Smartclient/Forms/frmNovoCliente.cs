using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotel.Entity;

namespace Hotel.Smartclient.Forms
{
    public partial class frmNovoCliente : Form
    {
        public frmNovoCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.teste();
        }
    }
}
