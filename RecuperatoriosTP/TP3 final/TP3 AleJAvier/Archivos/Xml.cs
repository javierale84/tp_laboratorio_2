using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
   public class Xml<T>:IArchivo<T>
    {
        public bool guardar(string archivo, T datos)
        {
            bool flag = false;
            try
            {
                using (XmlTextWriter Archivo = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializado = new XmlSerializer(typeof(T));
                    serializado.Serialize(Archivo, datos);
                    flag= true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return flag;
        }

        public bool leer(string archivo, out T datos)
        {
            bool flag = false;
            try
            {
                using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(lector);
                     flag= true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return flag;
        }
    }
}
