using LibreriaOperadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSuma1.Text) | (string.IsNullOrEmpty(txtSuma2.Text)))
            {
                MessageBox.Show("Por favor, ingrese ambos números para realizar la suma.");
            }
            else
            {
                Suma suma = new Suma(Convert.ToInt32(txtSuma1.Text), Convert.ToInt32(txtSuma2.Text));
                txtResultadoSuma.Text = suma.resultado.ToString();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResta1.Text) | (string.IsNullOrEmpty(txtResta2.Text)))
            {
                MessageBox.Show("Por favor, ingrese ambos números para realizar la suma.");
            }
            else
            {
                Resta resta = new Resta(Convert.ToInt32(txtResta1.Text), Convert.ToInt32(txtResta2.Text));
                txtResultadoResta.Text = resta.resultado.ToString();
            }
        }

        private void btnMultiplicación_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMultiplicación1.Text) | (string.IsNullOrEmpty(txtMultiplicacion2.Text)))
            {
                MessageBox.Show("Por favor, ingrese ambos números para realizar la suma.");
            }
            else
            {
                Multiplicacion multiplicacion = new Multiplicacion(Convert.ToInt32(txtMultiplicación1.Text), Convert.ToInt32(txtMultiplicacion2.Text));
                txtResultadoMultiplicacion.Text = multiplicacion.resultado.ToString();
            }
        }

        private void btnDivisión_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDivision1.Text) | (string.IsNullOrEmpty(txtDivision2.Text)))
            {
                MessageBox.Show("Por favor, ingrese ambos números para realizar la suma.");
            }
            else
            {
                Division division = new Division(Convert.ToInt32(txtDivision1.Text), Convert.ToInt32(txtDivision2.Text));
                txtResultadoDivision.Text = division.resultado.ToString();
            }
        }
    }
}
