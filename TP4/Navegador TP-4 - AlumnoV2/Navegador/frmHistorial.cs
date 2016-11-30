using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class frmHistorial : Form
    {
        public const string ARCHIVO_HISTORIAL = "historico.dat";
        /// <summary>
        /// Constructor publico. Inicializa el formulario.
        /// </summary>
        public frmHistorial()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga los datos del historial en la lista del formulario
        /// </summary>
        /// <param name="sender">objeto de tipo object</param>
        /// <param name="e">objeto de tipo EventArgs</param>
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            Archivos.Texto archivos = new Archivos.Texto(frmHistorial.ARCHIVO_HISTORIAL);
            List<String> datos;
            
            try
            {
                archivos.leer(out datos);
                this.Historial.DataSource= datos;
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

    }
}