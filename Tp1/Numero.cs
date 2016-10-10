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


/// <summary>
/// Constructor por defecto
/// </summary>
#region Constructor por defecto
        public Numero()
        {
            this._numero = 0;
        }
#endregion


      /// <summary>
      /// Constructor recibe un string
      /// </summary>
      /// <param name="numero"></param>
#region Constructor recibe un string
        public Numero(string numero)
        {
            this.setNumero(numero);
        }
#endregion

 /// <summary>
/// Constructor recibe un double
/// </summary>
/// <param name="numero"></param>
#region Constructor recibe un double
        public Numero(double numero)
        {
            this._numero = numero;
        }
#endregion


      /// <summary>
      /// Validacion de numero
      /// </summary>
      /// <param name="texto"></param>
      /// <returns></returns>
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


      /// <summary>
      /// Metodo para asignar valor
      /// </summary>
      /// <param name="numero"></param>
#region setter de numero
        public void setNumero(string numero)
        {

            this._numero = Numero.validarNumero(numero);
        }
#endregion


      /// <summary>
      /// Metodo para tomar el valor
      /// </summary>
      /// <returns></returns>
#region getter de numero
        public double getNumero()
        {
            return this._numero;
        }
#endregion







    }
    }

