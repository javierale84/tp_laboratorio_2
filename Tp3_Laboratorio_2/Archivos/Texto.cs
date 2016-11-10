using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto:IArchivo<string>
  
    {
            public bool guardar(string archivo, string dato)
            {
                try
                {

                    using (StreamWriter sw = new StreamWriter(archivo))
                    {
                        sw.Write(dato);
                    }

                    return true;
                }

                catch (Exception)
                {
                    return false;

                }
            }

            public bool leer(string archivo, out string dato)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        dato = sr.ReadToEnd();
                    }

                    return true;
                }

                catch (Exception)
                {
                    dato = default(string);// inicializa en el default de acuerdo al tipo de dato que sea

                    return false;
                   
                }
            }




    }
    }


