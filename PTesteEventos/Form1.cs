using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Nome alterado");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Evento leave - endereço PERDE foco");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("EVENTO ENTER - celular ganha foco");
        }
    }
}
