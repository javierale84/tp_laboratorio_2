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
        /// <summary>
        /// Instancio dos objetos de tipo numero que seran mis operandos
        /// </summary>
        Numero num1 = new Numero();
        Numero num2 = new Numero();

        /// <summary>
        /// Constructor del form, lo inicicializo con los operadores en el comboBox
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            cmbOperacion.Text = "Operador";
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }

        /// <summary>
        /// Load del Form, le doy titulo al formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora";
        }

        /// <summary>
        /// Metodo del campo de texto donde se ingresara el primer numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            num1.setNumero(txtNumero1.Text);
        }

        /// <summary>
        /// Metodo del comboBox donde seleccionara el operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo del campo de texto donde se ingresara el segundo numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            num2.setNumero(txtNumero2.Text);
        }


        /// <summary>
        /// Metodo del boton que limpia la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string textoOperador = "";

            Calculadora.Limpiar(num1, num2, textoOperador);

            txtNumero1.Text = num1.getNumero().ToString();
            txtNumero2.Text = num2.getNumero().ToString();
            cmbOperacion.Text = textoOperador;
            lblResultado.Text = "0";


        }
        /// <summary>
        /// Metodo del boton que realiza la operacion de la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Calculadora.operar(num1, num2, cmbOperacion.Text);

            lblResultado.Text = resultado.ToString();

        }

        /// <summary>
        /// En este label se mostrara el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
