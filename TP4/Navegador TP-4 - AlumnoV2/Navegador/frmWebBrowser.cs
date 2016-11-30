using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using Hilo;

namespace Navegador
{
    public partial class frmWebBrowser : Form
    {
        private const string ESCRIBA_AQUI = "Escriba aquí...";
        
        Archivos.Texto archivos;

        /// <summary>
        /// Constructor publico. Inicializa el Formulario.
        /// </summary>
        public frmWebBrowser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el formulario.
        /// </summary>
        /// <param name="sender">objeto de tipo Object</param>
        /// <param name="e">Objeto de tipo EventArgs</param>
        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            this.BarraDeBusqueda.SelectionStart = 0;  //This keeps the text
            this.BarraDeBusqueda.SelectionLength = 0; //from being highlighted
            this.BarraDeBusqueda.ForeColor = Color.Black;
            this.BarraDeBusqueda.BackColor= Color.Beige;
            this.BarraDeBusqueda.Text = frmWebBrowser.ESCRIBA_AQUI;

            archivos = new Archivos.Texto(frmHistorial.ARCHIVO_HISTORIAL);
        }

        #region "Escriba aquí..."
        private void txtUrl_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.IBeam; //Without this the mouse pointer shows busy
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.BarraDeBusqueda.Text.Equals(frmWebBrowser.ESCRIBA_AQUI) == true)
            {
                this.BarraDeBusqueda.Text = "";
                this.BarraDeBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.BarraDeBusqueda.Text.Equals(null) == true || this.BarraDeBusqueda.Text.Equals("") == true)
            {
                this.BarraDeBusqueda.Text = frmWebBrowser.ESCRIBA_AQUI;
                this.BarraDeBusqueda.ForeColor = Color.Gray;
            }
        }

        private void txtUrl_MouseDown(object sender, MouseEventArgs e)
        {
            this.BarraDeBusqueda.SelectAll();
        }
        #endregion

        delegate void ProgresoDescargaCallback(int progreso);
        /// <summary>
        /// Funcion Privada que muestra el prograso de la descarga.
        /// </summary>
        /// <param name="progreso">Entero que representa el progreso</param>
        private void ProgresoDescarga(int progreso)
        {
            if (statusStrip.InvokeRequired)
            {
                ProgresoDescargaCallback d = new ProgresoDescargaCallback(ProgresoDescarga);
                this.Invoke(d, new object[] { progreso });
            }
            else
            {
                barraProgreso.Value = progreso;
            }
        }
        delegate void FinDescargaCallback(string html);
        /// <summary>
        /// Funcion privada que carga el String html una vez que finalizo la descarga.
        /// </summary>
        /// <param name="html">String que guarda lo descargado de html</param>
        private void FinDescarga(string html)
        {
            if (rtxtHtmlCode.InvokeRequired)
            {
                FinDescargaCallback d = new FinDescargaCallback(FinDescarga);
                this.Invoke(d, new object[] { html });
            }
            else
            {
                rtxtHtmlCode.Text = html;
            }
        }
        /// <summary>
        /// Funcion privada que muestra el historial de paginas visitadas en el formulario historial.
        /// </summary>
        /// <param name="sender">objeto de tipo Object</param>
        /// <param name="e">objeto de tipo EventsArgs</param>
        private void mostrarTodoElHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial formHistorial = new frmHistorial();
            formHistorial.ShowDialog();
        }
        /// <summary>
        /// Funcion privada que al apretar el boton descarga la url pasada en el textbox
        /// </summary>
        /// <param name="sender">objeto de tipo Object</param>
        /// <param name="e">objeto de tipo EventsArgs</param>
        private void btnIr_Click(object sender, EventArgs e)
        {
            try
            {

                Uri link;

                
                if (!(Uri.TryCreate(this.BarraDeBusqueda.Text, UriKind.Absolute, out link)))
                {
                    BarraDeBusqueda.Text = "http://" + BarraDeBusqueda.Text;
                    link = new Uri(BarraDeBusqueda.Text);
                }
                Descargador descargador = new Descargador(link);
                descargador.progresoDescarga += this.ProgresoDescarga;
                descargador.finDescarga += this.FinDescarga;

                Thread hilo = new Thread(descargador.IniciarDescarga);
                hilo.Start();

                try
                {
                    archivos.guardar(this.BarraDeBusqueda.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }


            }
            catch (Exception exc)
            {
                this.rtxtHtmlCode.Text = exc.Message;

            }

        }



    }
}