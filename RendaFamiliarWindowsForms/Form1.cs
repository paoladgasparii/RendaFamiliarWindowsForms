using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RendaFamiliarWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Entrada de Dados
            double renda = double.Parse(txtRenda.Text);

            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTV.Text);
            double alimentacao = double.Parse(txtAlimentacao.Text);
            double outros = double.Parse(txtOutros.Text);

            // Processamento
            double gastos = energia + agua + tv + alimentacao + outros;
            double saldo = renda - gastos;

            // Saída de Dados
            lblGastos.Text = gastos.ToString("C");
            lblSaldo.Text = saldo.ToString("C");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário 
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa as Caixas de Texto
            txtRenda.Clear();
            txtEnergia.Clear();
            txtAgua.Clear();
            txtTV.Clear();
            txtAlimentacao.Clear();
            txtOutros.Clear();

            // Move o texto para a Label
            lblGastos.Text = "";
            lblSaldo.Text = "";

            // Move o cursor para a text box
            txtRenda.Focus();

        }
    }
}
