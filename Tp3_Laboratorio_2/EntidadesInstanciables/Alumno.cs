using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace EntidadesInstanciables
{
    public  sealed class Alumno:PersonaGimnasio
    {
        private Gimnasio.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        public enum EEstadoCuenta
        {
            MesPrueba,
            AlDia,
            Deudor,
        }

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

        protected override string ParticiparEnclase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TOMA CLASE DE:" + this._claseQueToma);

            return sb.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnclase());
            sb.AppendLine("Estado de cuenta:" + this._estadoCuenta);

            return sb.ToString();
        }

        public override string ToString()
        {
            string aux = "";
            if (this is Alumno)
            {
               aux+=  base.MostrarDatos();
            }

            return aux;
        }
        
        public static bool operator ==(Alumno a, Gimnasio.EClases clase)
        {
            if (a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Alumno a, Gimnasio.EClases clase)
        {
            return !(a._claseQueToma == clase);

        }
        
    }
}
