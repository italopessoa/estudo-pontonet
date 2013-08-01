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
    public partial class FormFilho2 : Form
    {
        public FormFilho2()
        {
            InitializeComponent();
        }

        public delegate void OnDataChangeHandler(Hashtable info);
        public event OnDataChangeHandler OnDataChange;

        public FormFilho2(List<string> lista)
        {
            InitializeComponent();
            foreach (string produto in lista)
            {
                lstProdutos.Items.Add(produto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verifica se o Form1 está aberto
            if (Application.OpenForms.OfType<FormFilho1>().Count() > 0)
            {
                Form form1 = Application.OpenForms["FormFilho1"];
                //seta as propriedades dos controles de Form1 com os controles do Form2
                Label label1 = (Label)form1.Controls["label1"];
                label1.Text = textBox1.Text;
                form1.Text = textBox2.Text;
                ((TextBox)form1.Controls["textBox1"]).BackColor = textBox3.BackColor;
                //aumenta o tamanho do form
                form1.Size = new Size(400, 400);
            }
            else
            {
                MessageBox.Show("O Form1 não está aberto!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable info = new Hashtable();
            info.Add("Valor1", textBox1.Text);
            info.Add("Valor2", textBox2.Text);
            info.Add("textBox3", textBox3);
            OnDataChange(info);
        }
    }
}
