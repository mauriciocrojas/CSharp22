using BibliotecaDeClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectoTestUnitarios
{
    [TestClass]
    public class ClaseTesteo
    {
        [TestMethod]
        [ExpectedException(typeof(DatosNoValidosException))]
        public void ProbarDatosNoValidosException()
        {
            Alumno unAlumno = new Alumno(25345, "Perez", 5, 6);
            SqlManejador.Insert(unAlumno);
        }
        [TestMethod]
        public void ProbarInsertarAlumno()
        {
            // Arrange - Preparar el caso de prueba
            Alumno unAlumno = new Alumno(40343546, "Perez", 5, 6);

            int resultadoEsperado = 1;

            // Act - Invocar al método a probar
            int resultado = SqlManejador.Insert(unAlumno);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }



}
