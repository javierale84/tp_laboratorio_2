using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    [Serializable]

   public class Instructor:PersonaGimnasio
    {
      
    
        private Queue<Gimnasio.EClases> _clasesDelDia;
        private static Random _random;

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this._clasesDelDia = new Queue<Gimnasio.EClases>();
            this.RandomClases();
            this.RandomClases();
        }

        static Instructor()
        {
            Instructor._random = new Random();
        }

        public Instructor()
        {
        }

        /// <summary>
        /// Metodo que asigna una clase al azar
        /// </summary>
        private void RandomClases()
        {
            this._clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(0, 3));
        }

        /// <summary>
        /// Metodo que retornara un string con las clases que tiene el Instructor
        /// </summary>
        /// <returns>Retornara un string con las clases que tiene el instructor</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            if(this._clasesDelDia!=null)
            { 

            sb.AppendLine("CLASE DEL DIA: ");
           foreach(Gimnasio.EClases item in this._clasesDelDia)
           {

                sb.AppendLine(item.ToString());
           }
                }


           return sb.ToString();
                
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.Append(this.ParticiparEnClase());
            return sb.ToString();

        }
        /// <summary>
        /// Metodo que hara publico los datos de un instructor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Verifica si el instructor da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Instructor i, Gimnasio.EClases clase)
        {
            if (!Object.ReferenceEquals(i, null))
            {     
                foreach (Gimnasio.EClases item in i._clasesDelDia)
                {
                    if (item == clase)
                    {
                        return true;
                        
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si el instructor no da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
           

                return !(i == clase);
            
        }
       
    }
}
