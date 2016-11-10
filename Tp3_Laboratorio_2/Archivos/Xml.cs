using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
  public  class Xml<T>:IArchivo<T>
    {
      public bool guardar(string xml, T dato)
      {
          try
          {
              using (XmlTextWriter tw = new XmlTextWriter(xml, Encoding.UTF8))
              {
                  XmlSerializer serial = new XmlSerializer(typeof(T));

                  serial.Serialize(tw, dato);
              }

              return true;
          }

          catch (Exception e)
          {
              return false;
              throw new ArchivosException(e);
              
          }
      }

      public bool leer(string xml, out T dato)
      {
          try
          {
              using (XmlTextReader tr = new XmlTextReader(xml))
              {
                  XmlSerializer serial = new XmlSerializer(typeof(T));

                  dato = (T)serial.Deserialize(tr);
              }

              return true;
          }

          catch (Exception e)
          {
             
              dato = default(T);
              return false;
              throw new ArchivosException(e);


          }
      }
    }
}
