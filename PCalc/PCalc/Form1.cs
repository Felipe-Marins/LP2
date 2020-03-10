using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class PVolume : Form
    {
        public PVolume()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtAltura.Text = "";
            txtVolume.Text = "";
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura, volume;


            if (Convert.ToDouble(txtAltura.Text) <= 0 || Convert.ToDouble(txtRaio.Text) <= 0)
            {
                MessageBox.Show("Entrada Inválida!!\n\n Digite uma entrada maior que 0");
            }
            altura = Convert.ToDouble(txtAltura.Text);
            raio = Convert.ToDouble(txtRaio.Text);
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            txtVolume.Text = volume.ToString();
            

        }
    }
}
