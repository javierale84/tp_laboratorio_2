using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        private string html;
        private Uri direccion;

        public delegate void FinDescargaCallback(string html);
        public delegate void ProgresoDescargaCallback(int progreso);

        public event FinDescargaCallback finDescarga;
        public event ProgresoDescargaCallback progresoDescarga;


       
        //public delegate void EventProgress(int status);
        //public event EventProgress eventoProgreso;
        //public delegate void EventCompleted(string pagina);
        //public event EventCompleted eventoCompleted;





        public Descargador(Uri direccion)
        {
            this.html = "";
            this.direccion = direccion;
        }

        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged += WebClientDownloadProgressChanged;
                cliente.DownloadStringCompleted += WebClientDownloadCompleted;

                cliente.DownloadStringAsync(this.direccion);
            }
            catch (Exception e)
            {
                throw e;
            }
    }
   
        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
           progresoDescarga(e.ProgressPercentage);
    
        }
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            //try
            //{
            //     pongo el contenido del html en el richTextBox
            //    this.html = e.Result;
            //}
            //catch (Exception ex)
            //{
            //    En caso de error muestro el contenido a traves del richTextBox
            //    this.html = ex.InnerException.Message;
            //}
            //finally
            //{
            //     paso el contenido de la página/error para que lance el evento y actualice el richTextBox.
            //    this.eventoCompleted(this.html);
            //}

            finDescarga(e.Result);
        }
    }
}
