using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeGastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double GastoTotal = double.Parse(txtEnergiaEletrica.Text) + double.Parse(txtAgua.Text) + double.Parse(txtFone.Text) + double.Parse(txtAlimentacao.Text) + double.Parse(txtOutros.Text);
            double Saldo = double.Parse(txtRendaFamiliar.Text) - GastoTotal;

            lblGastoTotal.Text = GastoTotal.ToString();
            lblSaldo.Text = Saldo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRendaFamiliar.Text = "";
            txtEnergiaEletrica.Text = "";
            txtAgua.Text = "";
            txtFone.Text = "";
            txtAlimentacao.Text = "";
            txtOutros.Text = "";
            lblGastoTotal.Text = "0";
            lblSaldo.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
