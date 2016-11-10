using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public  class DniInvalidoException:Exception
    {
      private static string _mensajeBase="El dni es invalido";

      public DniInvalidoException(string mensaje)
          : base(_mensajeBase+mensaje)
      {
      }
      public DniInvalidoException()
          : base(_mensajeBase)
      {
      }

      public DniInvalidoException(Exception e)
          : base(_mensajeBase,e)
      {
      }

      public DniInvalidoException(string mensaje, Exception e)
          : base(_mensajeBase+mensaje, e)
      {
      }

    }
}
