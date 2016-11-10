using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Archivos;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        private List<Alumno> _alumnos;
        private Gimnasio.EClases _clase;
        private Instructor _instructor;

        //Indexador
        public Jornada this[int indice]
        {
            get { return this[indice]; }
        }

        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }

        public Jornada(Gimnasio.EClases clases, Instructor instructor)
            : this()
        {
            this._clase = clases;
            this._instructor = instructor;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {

            if (a == j._clase)
            {
                return true;
            }
            return false;
        }


        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            bool flag = false;

            foreach (Gimnasio.EClases item in j._instructor._clasesDelDia)
            {
                if (a == item)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                j._alumnos.Add(a);
            }

            return j;
        }

        //Sobrecargar el metodo To String
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Clase:"+ this._clase.ToString());
            sb.AppendLine("Instructor:"+this._instructor.ToString());
            sb.AppendLine("Datos de los alumnos:");

            foreach (Alumno item in this._alumnos)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();

        }


        public static bool Guardar(Jornada jornada)
        {
            Texto text = new Texto();

            if (text.guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jornada.txt",jornada.ToString()))
            {
                return true;
            }

            return false;
        }

        

        public static bool Leer(Jornada jornada)
        {
          Texto text= new Texto();

            string dato=jornada.ToString();

          if (text.leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jornada.txt", out dato))
          {
              return true;
          }
          return false;
        }
        }
    }

    

