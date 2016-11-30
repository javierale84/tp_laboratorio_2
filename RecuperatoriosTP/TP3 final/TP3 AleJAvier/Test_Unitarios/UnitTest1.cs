using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesInstanciables;
using EntidadesAbstractas;

namespace Test_Unitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComprobarValorNumerico()
        {
            Alumno a1;
            //Devuelve una exception de tipo DniInvalidoException
            try
            {
                a1 = new Alumno(10, "Juan", "Lopez", "22222", Persona.ENacionalidad.Argentino, Gimnasio.EClases.Natacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));

            }

            //Devuelve una exception de tipo NacionalidadInvalidadException
            try
            {
                Alumno a2 = new Alumno(7, "Julio", "Perez", "111", Persona.ENacionalidad.Extranjero, Gimnasio.EClases.Natacion);

            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }


        [TestMethod]
        public void ComprobarNulos()
        {
            Alumno a3 = new Alumno(9, "Miguel", "Martinez", "123", Persona.ENacionalidad.Argentino, Gimnasio.EClases.Pilates, Alumno.EEstadoCuenta.AlDia);

            Assert.AreEqual(123, a3.DNI);
            Assert.AreEqual(Persona.ENacionalidad.Argentino, a3.Nacionalidad);

            Instructor I1 = new Instructor(13, "Luis", "Lopez", "97000000", Persona.ENacionalidad.Extranjero);
           
            Assert.AreEqual(Persona.ENacionalidad.Extranjero, I1.Nacionalidad);
            Assert.AreEqual(97000000, I1.DNI);

        }
    }
}
