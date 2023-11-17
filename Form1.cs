using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_gasolina_etanol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double etanol = Convert.ToDouble(textBox1.Text);
            double gasolina = Convert.ToDouble(textBox2.Text);
            double resultado = etanol/gasolina;

            if (resultado < 0.7)
            {
                label4.Text = "Etanol";
            }
            else label4.Text = "Gasolina";

        }
    }
}
