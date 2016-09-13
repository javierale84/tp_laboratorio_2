using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Prog2
{
  public  class Numero
    {
        private double _numero;



#region Constructor por defecto
        public Numero()
        {
            this._numero = 0;
        }
#endregion

#region Constructor recibe un string
        public Numero(string numero)
        {
            this.setNumero(numero);
        }
#endregion

#region Constructor recibe un double
        public Numero(double numero)
        {
            this._numero = numero;
        }
#endregion

#region Metodo que Valida Numero
        private static double validarNumero(string texto)
        {
            double numero;

            if (Double.TryParse(texto, out  numero))
            {
                return numero;
            }

            else 

                return 0;
        }
#endregion

#region setter de numero
        public void setNumero(string numero)
        {

            this._numero = Numero.validarNumero(numero);
        }
#endregion

#region getter de numero
        public double getNumero()
        {
            return this._numero;
        }
#endregion







        internal void setNumero(System.Windows.Forms.TextBox textBox1)
        {
            throw new NotImplementedException();
        }
    }
    }

