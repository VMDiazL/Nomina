using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calcular = double.Parse(txtPrecioHora.Text) * double.Parse(txtHorasTrabajadas.Text);

            txtNombre.Text = $"El salario del trabajador {txtNombreEmpleado.Text} es de:";
            txtResultado.Text = $"${calcular} Pesos";



        }
    }
}
