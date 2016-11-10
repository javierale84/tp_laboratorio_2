using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
 public sealed  class Instructor:PersonaGimnasio
    {

     public Queue<Gimnasio.EClases> _clasesDelDia;
     private static Random _random;

     static Instructor()
     {
         _random = new Random();
     }

     private void RandomClases()
     {
         this._clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(0, Enum.GetNames(typeof(Gimnasio.EClases)).Length));
     }

     public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
         :base(id,nombre,apellido,dni,nacionalidad)
     {
         this._clasesDelDia = new Queue<Gimnasio.EClases>();
         this.RandomClases();
         this.RandomClases();
     }

    

     protected override string ParticiparEnclase()
     {
         StringBuilder sb = new StringBuilder();

         foreach (Gimnasio.EClases elemento in this._clasesDelDia)
            {
                sb.AppendLine("CLASES DEL DIA:" + elemento);
            }

          return sb.ToString();
     }

     protected override string MostrarDatos()
     {
        return base.MostrarDatos();

     }

     public override string ToString()
     {
         return this.ParticiparEnclase() + this.MostrarDatos();
     
     }

     public static bool operator ==(Instructor ins, Gimnasio.EClases clase)
     {
         foreach (Gimnasio.EClases item in ins._clasesDelDia)
         {
             if (item == clase)
             {
                 return true;
             }
         }

         return false;

     }

     public static bool operator !=(Instructor ins, Gimnasio.EClases clase)
     {
         return !(ins == clase);
     }
        
     

    }
}
