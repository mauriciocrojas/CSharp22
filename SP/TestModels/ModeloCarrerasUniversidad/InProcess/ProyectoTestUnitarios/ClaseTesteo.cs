using BibliotecaDeClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectoTestUnitarios
{
    [TestClass]
    public class ClaseTesteo
    {
        [TestMethod]
        public void ProbarInsertCorrecto()
        {
            //Arrange
            int resultadoEsperado = 1;

            //Act
            SqlManejador sqlManejador = new SqlManejador();
            Alumno alumno = new Alumno(40000000, "Pepe Roni", 4, 10);
            int resultado = sqlManejador.Insertar(alumno);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod]
        [ExpectedException(typeof(DatosNoValidosException))]
        public void ProbarDatosNoValidosException()
        {
            SqlManejador sqlManejador = new SqlManejador();

            Alumno unAlumno = new Alumno(25345, "Perez", 5, 6);
            int resultado = sqlManejador.Insertar(unAlumno);
        }
    }
}
