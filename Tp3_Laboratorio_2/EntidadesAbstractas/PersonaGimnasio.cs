using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
   public abstract class PersonaGimnasio:Persona
    {
       private int _identificador;

       public override bool Equals(object obj)
        {
           if(!(obj is PersonaGimnasio))
           { 
               return false;
           }
// Es suficiente preguntando solo si es del mismo tipo?
           return true;
        }

       protected virtual string MostrarDatos()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("ID Persona Gimnasio:" + this._identificador);
           sb.AppendLine(base.ToString());

           return sb.ToString();
       }

       public PersonaGimnasio(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :
           base(nombre, apellido, dni, nacionalidad)
       {
           this._identificador = id;

       }

       protected abstract string ParticiparEnclase();

       public static bool operator ==(PersonaGimnasio pg1, PersonaGimnasio pg2)
       {
           if (pg1.Equals(pg2) && ((pg1.DNI == pg2.DNI) || pg1._identificador == pg2._identificador))
           {
               return true;
           }

           return false;
       }

       public static bool operator !=(PersonaGimnasio pg1, PersonaGimnasio pg2)
       {
           return !(pg1 == pg2);
       }
      

      
    }
}
