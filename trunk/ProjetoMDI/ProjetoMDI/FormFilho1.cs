using System;
using System.Collections;
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
    public partial class FormFilho1 : Form
    {
        public FormFilho1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listaProdutos = new List<string>();
            listaProdutos.Add("Mouse");
            listaProdutos.Add("Notebook");
            listaProdutos.Add("Teclado");
            FormFilho2 form2 = new FormFilho2(listaProdutos);
            form2.OnDataChange += new FormFilho2.OnDataChangeHandler(form2_OnDataChange);
            form2.Show();
        }

        private void form2_OnDataChange(Hashtable info)
        {
            label1.Text = info["Valor1"].ToString();
            this.Text = info["Valor2"].ToString();
            textBox1.BackColor = ((TextBox)info["textBox3"]).BackColor;
            this.Size = new Size(300, 155);
        }
    }
}
