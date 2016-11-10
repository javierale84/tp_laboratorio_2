using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {

        #region Atributos

        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;
        private string _nombre;

        #endregion

        public enum ENacionalidad
        {
            Argentino, Extranjero
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = this.ValidarNombreApellido(value); }
        }

        public int DNI
        {
            get { return this._dni; }
            set { this._dni = this.ValidarDni(this.Nacionalidad,value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = this.ValidarNombreApellido(value); }
        }

        public string StringToDNI
        {

            set { this.ValidarDni(this.Nacionalidad, value); }
        }

        




        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido= apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            :this(nombre,apellido,nacionalidad)
        {
            this.DNI= dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
           

            if(nacionalidad==ENacionalidad.Argentino && (dato>89999999))
            {
                throw new NacionalidadInvalidaException();
            }


            if(nacionalidad==ENacionalidad.Extranjero && dato<=89999999)
            
            {
                
               
                throw new NacionalidadInvalidaException();
            }

            if(dato<1)
            {
                throw new DniInvalidoException();
            }


            return dato;

        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
             int numero;

            if (!int.TryParse(dato, out  numero))
            {
                  throw new DniInvalidoException();
            }

       
            return this.ValidarDni(nacionalidad,numero);
              
        }
 private  string ValidarNombreApellido(string dato)
        {
          
            Regex regex = new Regex(@"[a-zA-Z]*");
            // Valido el dato
            Match match = regex.Match(dato);
    

    

            if (match.Success)
                return match.Value;
            else
                return "";
        }

 public override string ToString()
 {
     StringBuilder sb = new StringBuilder();

     sb.AppendLine("Nombre:" + this.Nombre);
     sb.AppendLine("Nombre:" + this.Apellido);
     sb.AppendLine("Nombre:" + this.DNI);
     sb.AppendLine("Nombre:" + this.Nacionalidad);

     return sb.ToString();

 }



    }
}
