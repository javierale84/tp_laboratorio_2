using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Prog2
{
    public partial class Form1 : Form
    {
        Numero num1 = new Numero();
        Numero num2 = new Numero();


        public Form1()
        {
            InitializeComponent();
            cmbOperacion.Text = "Operador";
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora";
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            num1.setNumero(txtNumero1.Text);
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            num2.setNumero(txtNumero2.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string textoOperador = "";

            Calculadora.Limpiar(num1, num2, textoOperador);

            txtNumero1.Text = num1.getNumero().ToString();
            txtNumero2.Text = num2.getNumero().ToString();
            cmbOperacion.Text = textoOperador;
            lblResultado.Text = "0";


        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Calculadora.operar(num1, num2, cmbOperacion.Text);

            lblResultado.Text = resultado.ToString();

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
