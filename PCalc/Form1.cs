using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            txtResultado.Text = String.Empty;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(txtNum1.Text, out verify1) &&
                double.TryParse(txtNum2.Text, out verify2)))
            {
                double soma = verify1 + verify2;
                txtResultado.Text = soma.ToString("N2");
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(txtNum1.Text, out verify1) &&
                double.TryParse(txtNum2.Text, out verify2)))
            {
                double subtracao = verify1 - verify2;
                txtResultado.Text = subtracao.ToString("N2");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(txtNum1.Text, out verify1) &&
                double.TryParse(txtNum2.Text, out verify2)))
            {
                double multiplicacao = verify1 * verify2;
                txtResultado.Text = multiplicacao.ToString("N2");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(txtNum1.Text, out verify1) &&
                double.TryParse(txtNum2.Text, out verify2)))
            {
                if (verify2 == 0)
                    MessageBox.Show("Divisor não pode ser igual a zero!");
                else
                {
                    double divisao = verify1 / verify2;
                    txtResultado.Text = divisao.ToString("N2");
                }
            }
        }
    }
}
