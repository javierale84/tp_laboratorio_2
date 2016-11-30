using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;

namespace EntidadesInstanciables
{
      [Serializable]
      
    public class Gimnasio
    {
        public enum EClases { CrossFit, Natacion, Pilates, Yoga }

        #region "Atributos"
        private List<Alumno> _alumnos;
        private List<Instructor> _instructores;
        private List<Jornada> _jornada;
        private EClases _clases;
        #endregion

        #region "Propiedades"

        public Jornada this[int i] { get { return this._jornada[i]; } }

        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        public List<Instructor> Instructor
        {
            get { return this._instructores; }
            set { this._instructores = value; }


        }

        public List<Jornada> Jornada
        {
            get { return this._jornada; }
            set { this._jornada = value; }
        }

        public EClases Clases
        {
            get { return this._clases; }
            set { this._clases = value; }
        }

        #endregion

        #region "Metodos"

        #region "Constructores"

        public Gimnasio()
        {
            this._alumnos = new List<Alumno>();
            this._instructores = new List<Instructor>();
            this._jornada = new List<Jornada>();
        }


        

        #endregion

        public static bool Guardar(Gimnasio gim)
        {
            Xml<Gimnasio> Xml = new Xml<Gimnasio>();
            try
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Gimnasio.xml";
                Xml.guardar(path, gim);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivoException(e);
            }
        }

        public static bool Leer(Gimnasio gim)
        {
            Xml<Gimnasio> Xml = new Xml<Gimnasio>();
            try
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Gimnasio.xml";
                Xml.leer(path, out gim);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivoException(e);
            }
        }

        private static string MostrarDatos(Gimnasio gim)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada j in gim._jornada)
            {
                sb.Append(j.ToString());
                sb.AppendLine("<---------------------------------------->");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }

        #endregion

        #region "Operadores"

        public static bool operator ==(Gimnasio g, Alumno a)
        {
            foreach (Alumno alumno in g._alumnos)
            {
                if (alumno == a)
                    return true;
            }
            return false;
        }
        public static Instructor operator ==(Gimnasio g, EClases clase)
        {
            foreach (Instructor i in g._instructores)
            {
                if (i == clase)
                    return i;
            }
            throw new SinInstructorException();
        }

        public static bool operator ==(Gimnasio g, Instructor i)
        {
            foreach (Instructor inst in g._instructores)
            {
                if (inst == i)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Gimnasio g, Alumno a)
        { return !(g == a); }

        public static Instructor operator !=(Gimnasio g, EClases clase)
        {
            foreach (Instructor i in g._instructores)
            {
                if (i != clase)
                    return i;
            }
            return null;
        }

        public static bool operator !=(Gimnasio g, Instructor i)
        { return !(g == i); }


        public static Gimnasio operator +(Gimnasio g, Gimnasio.EClases clase)
        {
            if (!object.Equals(g, null) && !object.Equals(clase, null))
            {
                Instructor instructor = (g == clase);
                if (instructor != null)
                {
                    Jornada jornadaAgregar = new Jornada(clase, instructor);
                    for (int i = 0; i < g._alumnos.Count; i++)
                    {
                        if (g._alumnos[i] == clase)
                            jornadaAgregar += g._alumnos[i];
                    }
                    g._jornada.Add(jornadaAgregar);
                }

            }
            return g;
        }


        public static Gimnasio operator +(Gimnasio g, Instructor i)
        {
            if (g != i) { g._instructores.Add(i); }
            return g;
        }

        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            if (g != a) { g._alumnos.Add(a); }
            return g;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

     

        #endregion
    }
}

