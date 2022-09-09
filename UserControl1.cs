using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTeste1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            Operacoes operacoes = new Operacoes();
            int total = operacoes.Soma(n1, n2);
            label4.Text = total.ToString("f0"); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            Operacoes operacoes = new Operacoes();
            int total = operacoes.Subtracao(n1, n2);
            label4.Text = total.ToString("f0");
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            Operacoes operacoes = new Operacoes();
            int total = operacoes.Multiplicacao(n1, n2);
            label4.Text = total.ToString("f0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            Operacoes operacoes = new Operacoes();
            int total = operacoes.Divisao(n1, n2);
            label4.Text = total.ToString("f0");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            label4.Text = " ";
        }
    }
}
