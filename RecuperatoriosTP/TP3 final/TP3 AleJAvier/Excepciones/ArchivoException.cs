﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   public class ArchivoException:Exception
    {
        public ArchivoException(Exception innerException)
            : base("El archivo no pudo ser guardado", innerException)
        { }
    }
}
