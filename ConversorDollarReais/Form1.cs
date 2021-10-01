using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDollarReais
{
    public partial class CalcularDolar : Form
    {
        private int priceDollar;
        private int dollars;
        private int percent;

        public CalcularDolar()
        {
            InitializeComponent();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double qtdDolar;
            double precoDolar;
            double porcento = 3;
            double total;
            qtdDolar = Convert.ToInt32(txtQuantidade.Text);
            precoDolar = Convert.ToDouble(txtValor.Text);
            porcento = (precoDolar * qtdDolar) * porcento / 100;
            total = (precoDolar * qtdDolar) + porcento;
            lblRe.Text = Convert.ToString(total.ToString("C"));

            
        }

        private void CalcularDolar_Load(object sender, EventArgs e)
        {

        }
    }
}
