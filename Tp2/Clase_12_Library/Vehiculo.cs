using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library_2
{
    public abstract class Vehiculo
    {
       public  enum EMarca
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }
        EMarca _marca;
        string _patente;
        ConsoleColor _color;

        public Vehiculo(EMarca marca, string patente, ConsoleColor color)
        {
            this._marca = marca;
            this._patente = patente;
            this._color = color;
                
        }

        /// <summary>
        /// Retornará la cantidad de ruedas del vehículo
        /// </summary>
       public abstract short CantidadRuedas { get; }

        public virtual  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("PATENTE:"+ this._patente);
            sb.AppendLine("MARCA  :"+ this._marca.ToString());
            sb.AppendLine("COLOR  :"+this._color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        /// 
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1._patente == v2._patente)
            {
                return true;
            }
            return false;
        }

       
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
