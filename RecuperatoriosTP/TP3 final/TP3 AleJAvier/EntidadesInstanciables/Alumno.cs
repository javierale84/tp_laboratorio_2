using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    [Serializable]
  public sealed class Alumno:PersonaGimnasio
    {
        public enum EEstadoCuenta
        {
            MesPrueba,
            AlDia,
            Deudor
        }

        private Gimnasio.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        #region "Constructores"
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }

       public Alumno()
        { }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo sobreescrito que mostrara los datos de un Alumno
        /// </summary>
        /// <returns>Retornara un string con los datos de un Alumno</returns>
        protected override string MostrarDatos()
        {
            return base.MostrarDatos();
        }


        /// <summary>
        /// Metodo sobreescrito de la clase Persona Gimnasio.
        /// </summary>
        /// <returns>Retornara un string con la clase que toma el Alumno</returns>
        protected override string ParticiparEnClase()
        {
            string mensaje = "TOMA CLASES DE:" + this._claseQueToma.ToString();
            return mensaje;
        }

        /// <summary>
        /// Metodo que hara publico los datos de un Alumno.
        /// </summary>
        /// <returns>Retornara un string con todos los datos de un Alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos() + this.ParticiparEnClase() + "\nESTADO DE CUENTA:" + this._estadoCuenta.ToString() + "\n";
        }

        /// <summary>
        /// Verifica si un alumno toma esa clase y su estado de estado no es deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Gimnasio.EClases clase)
        {
            if (!Object.ReferenceEquals(a, null))
            {
                if (a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si el alumno no toma esa clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Gimnasio.EClases clase)
        {
            if (!Object.ReferenceEquals(a, null))
            {
                if (a._claseQueToma != clase)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
