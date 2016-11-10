using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml.Serialization;
using System.Xml;
using Archivos;


namespace EntidadesInstanciables
{
   public class Gimnasio
    {
       private List<Alumno> _alumnos;
       private List<Instructor> _intructores;
       private List<Jornada> _jornada;

       public enum EClases
       {
           Pilates = 2,
           CrossFit = 0,
           Natacion = 1,
           Yoga = 3,

       }
      

       public Jornada this[int indice]
       {
           get { return this[indice]; }
       }

       public Gimnasio()
       {
           this._alumnos = new List<Alumno>();
           this._intructores = new List<Instructor>();
           this._jornada = new List<Jornada>();
       }


       public static bool operator==(Gimnasio gim, Alumno alu)
       {

           foreach (Alumno item in gim._alumnos)
           {
               if (item == alu)
               {
                   return true;
               }
           }

               return false;
        }

       public static bool operator !=(Gimnasio gim, Alumno alu)
       {
           return !(gim == alu);
       }

       public static bool operator ==(Gimnasio gim, Instructor ins)
       {
           foreach (Instructor item in gim._intructores)
           {
               if (item == ins)
               {
                   return true;
               }
           }
           return false;
       }

       public static bool operator !=(Gimnasio gim, Instructor ins)
       {
           return !(gim == ins);
       }


       public static Instructor operator ==(Gimnasio gim, EClases clase)
       {
           Instructor instructor=null;
           
           foreach (Instructor item in gim._intructores)
           {
               if (item == clase)
               {
                   instructor= item;
                   break;
               }
           
               else
               {
                   throw new SinInstructorException();
                   
               }
           }

           return instructor;
         }

       public static Instructor operator !=(Gimnasio gim, EClases clase)
       {
            Instructor instructor=null;
           
           foreach (Instructor item in gim._intructores)
           {
               if (item != clase)
               {
                   instructor= item;
                   break;
               }
                        
           }

           return instructor;
         }

       public static Gimnasio operator +(Gimnasio gim, EClases clase)
       {
           switch (clase)
           {
               case EClases.CrossFit:

                   Instructor ins = gim == clase;
                   Jornada nuevaJornada = new Jornada(clase, ins);

                   foreach (Alumno item in gim._alumnos)
                   {
                       if (item == clase)
                       {
                           nuevaJornada += item;
                       }
                   }

                   gim._jornada.Add(nuevaJornada);

                   break;

               case EClases.Natacion:

                   Instructor ins2 = gim == clase;
                   Jornada nuevaJornada2 = new Jornada(clase, ins2);

                   foreach (Alumno item in gim._alumnos)
                   {
                       if (item == clase)
                       {
                           nuevaJornada2 += item;
                       }
                   }

                   gim._jornada.Add(nuevaJornada2);

                   break;

               case EClases.Pilates:

                   Instructor ins3 = gim == clase;
                   Jornada nuevaJornada3 = new Jornada(clase, ins3);

                   foreach (Alumno item in gim._alumnos)
                   {
                       if (item == clase)
                       {
                           nuevaJornada3 += item;
                       }
                   }

                   gim._jornada.Add(nuevaJornada3);

                   break;

               default:
                   return gim;
           }

           return gim;
       }


       public static Gimnasio operator +(Gimnasio gim, Alumno a)
       {
           bool flag = false;
           try
           {
               foreach (Alumno item in gim._alumnos)
               {
                   if (item == a)
                   {
                       flag = true;
                   }
               }
               if (flag == false)
               {
                   gim._alumnos.Add(a);
               }

               else
               {
                   throw new AlumnoRepetidoException();
               }
           }

           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
           return gim;
       }

        public static Gimnasio operator +(Gimnasio gim, Instructor ins)
       {
           bool flag = false;

           foreach (Instructor item in gim._intructores)
           {
               if (item == ins)
               {
                   flag = true;
               }
           }
           if (flag == false)
           {
               gim._intructores.Add(ins);
           }

           return gim;
       }

       private static string MostrarDatos(Gimnasio gim)
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("JORNADAS:");

           foreach(Jornada item in gim._jornada)
           {
               sb.AppendLine( item.ToString());
           }

           sb.AppendLine("INSTRUCTORES:");

            foreach(Instructor item in gim._intructores)
           {
               sb.AppendLine( item.ToString());
           }

           sb.AppendLine("ALUMNOS:");

              foreach(Alumno item in gim._alumnos)
           {
               sb.AppendLine( item.ToString());
           }

           return sb.ToString();

       }

       public override string ToString()
       {
           return Gimnasio.MostrarDatos(this);
       }

       public static bool Guardar(Gimnasio gim)
       {
           Xml<Gimnasio> xml = new Xml<Gimnasio>();

           if (xml.guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Gimnasio.xml", gim))
           {
               return true;
           }

           return false;
       }

       public static bool Leer(Gimnasio gim)
       {
           Xml<Gimnasio> xml = new Xml<Gimnasio>();

           if (xml.leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Gimnasio.xml", out gim))
           {
               return true;
           }

           return false;
       }





       }


       }




    

