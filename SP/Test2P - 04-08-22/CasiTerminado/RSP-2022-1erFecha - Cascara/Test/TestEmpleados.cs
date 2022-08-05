using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaDeClases;

namespace Test
{
    [TestClass]
    public class TestEmpleados
    {
        [TestMethod]
        [ExpectedException(typeof(DatoErroneoException))]
        public void ProbarDatoErroneoExceptionn()
        {
            SqlManejador sqlManejador = new SqlManejador();

            Empleado unEmpleado = new Empleado(25345, "Perez", "Lider", true);
            int resultado = sqlManejador.Insertar(unEmpleado);
        }

        [TestMethod]
        public void ProbarInsertCorrecto()
        {
            //Arrange
            int resultadoEsperado = 1;

            //Act
            SqlManejador sqlManejador = new SqlManejador();
            Empleado empleado = new Empleado(40000000, "Pepe Roni", "Analista", true);
            int resultado = sqlManejador.Insertar(empleado);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);

        }
    }
}
