using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException(string mensaje)
            : base("No coincide la nacionalidad con el dni ingresado"+mensaje)
        {
        }

        public NacionalidadInvalidaException()
            : base("No coincide la nacionalidad con el dni ingresado")
        {
        }

        
    
    }
}
