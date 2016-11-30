﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public  class DniInvalidoException:Exception
    {
        private static string mensajeBase = "El Dni ingresado es un numero inválido.";

        public DniInvalidoException()
            : base(mensajeBase)
        { }

        public DniInvalidoException(Exception e)
            : base(mensajeBase, e)
        { }

    

        public DniInvalidoException(string message)
            : this(message, null)
        { }

        public DniInvalidoException(string message, Exception innerException)
            : base(mensajeBase + message, innerException)
        { }
    }
}
