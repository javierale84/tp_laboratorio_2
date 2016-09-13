using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Prog2
{
    class Calculadora
    {
        /// <summary>
        /// Metodo que realiza la operacion de la calculadora
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        #region Metodo Operar
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado;



            #region switch del operador

            switch (operador)
            {
                   
                   case"+":

                   resultado = numero1.getNumero() + numero2.getNumero(); 
                    break;
                
                   case"-":

                   resultado = numero1.getNumero() - numero2.getNumero(); 
                    break;

                   case "*":

                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;

                   case "/":

                    if (numero2.getNumero() == 0)
                    {
                        resultado = 0;
                    }

                    else
                    {
                        resultado = numero1.getNumero() / numero2.getNumero();
                    }
                    break;

                    default:
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;
            }

           
            #endregion 

            return resultado;
        }
        #endregion


        /// <summary>
        /// Metodo que valida el operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        #region Metodo que valida el operador

        public static string validarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                operador= "+";
            }

            return operador;
        }
        #endregion

       
        /// <summary>
        /// Metodo que limpia y pone en 0 los valores de la calculadora
        /// </summary>
        /// <param name="uno"></param>
        /// <param name="dos"></param>
        /// <param name="operador"></param>
        #region Metodo que Limpia
        public static void Limpiar(Numero uno, Numero dos, string operador)
        {
            uno.setNumero("");
            dos.setNumero("");
            operador = "";
        }
        #endregion
    }
    }

