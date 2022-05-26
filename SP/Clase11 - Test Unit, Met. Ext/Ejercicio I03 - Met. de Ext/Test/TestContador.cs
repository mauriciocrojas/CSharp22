//Consigna
//En un proyecto de consola, crear un método de extensión para la clase string que 
//cuente la cantidad de signos de puntuación punto (.), coma(,) y punto y coma (;) dentro de una cadena.

//Pedir el ingreso de un texto por consola y mostrar la cantidad de signos de puntuación que contiene.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class TestContador
    {
        [TestMethod]
        public void Probar_ContarSimbolosPuntuacion()
        {
            //Arrange

            string texto = "hola, Juan Carlos; cómo estás.?";
            int expectated = 3;

            //Act
            int actual = texto.ContarSimbolosPuntuacion();

            //Assert
            Assert.AreEqual(expectated, actual);
        }

        [TestMethod]
        public void Probar_ContarCaracterEspecifico()
        {
            //Arrange
            string texto = "hola, buenos dias a todos";
            int expectated = 3;

            //Act
           int actual = texto.ContarCaracterEspecifico('a');

            //Assert
            Assert.AreEqual(expectated, actual);
        }
    }
}
