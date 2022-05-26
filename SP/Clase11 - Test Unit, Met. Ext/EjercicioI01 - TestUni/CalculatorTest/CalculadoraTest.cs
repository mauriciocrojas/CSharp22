//Crear una calculadora de string con un m�todo int Add (string numeros) y 
//automatizar las pruebas unitarias para cada uno de los siguientes puntos.

//SUGERENCIAS
//Comience con el caso de prueba m�s simple de un string vac�o y pase a uno y dos n�meros
//Recuerde resolver las cosas de la forma m�s sencilla posible
//Recuerde refactorizar despu�s de cada prueba aprobada.
//IMPORTANTE
//El objetivo es aprender a trabajar de forma incremental.

//Hac� una tarea a la vez y trat� de no seguir leyendo los siguientes puntos.

//Parte I
//El m�todo Add debe poder tomar hasta dos n�meros separados por comas, y devolver� su suma.

//Por ejemplo "" o "1" o "1,2" como entradas (para un string vac�o devolver� 0).

//Parte II
//Permitir que el m�todo Add maneje una cantidad desconocida de n�meros.

//Parte III
//Permita que el m�todo Add admita salto de l�nea entre n�meros (en lugar de comas).

//La siguiente entrada est� bien: "1 \ n2,3"(ser� igual a 6).
//La siguiente entrada NO est� bien: "1, \ n"(no es necesario probarlo, solo se aclara)
//Parte IV
//Permitir que el m�todo Add soporte diferentes delimitadores.

//Para cambiar un delimitador, el comienzo del string contendr� dos barras, debe verse as�:

//// [delimitador] \ n [n�meros ...]

//Por ejemplo: "//; \ n1; 2" debe devolver tres donde el valor predeterminado delimitador es ';'.

//Las barras son opcionales. Todos los escenarios existentes a�n deben ser compatibles.

//Parte V
//Si Add recibe un n�mero negativo arrojar� una excepci�n NegativoNoPermitidoException que en su 
//mensaje contendr� el negativo que se recibi�.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace CalculatorTest
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Add_ProbarSumaDeString()
        {
            // Arrange - Preparar el caso de prueba
            string numeros = "1,2";
            Calculadora calculadora = new Calculadora();
            int resultadoEsperado = 3;

            // Act - Invocar al m�todo a probar
            int resultado = calculadora.Add(numeros);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Add_ProbarSumaDeStringConSaltoDeLinea()
        {
            // Arrange - Preparar el caso de prueba
            string numeros = @"1 \ n2,3";
            Calculadora calculadora = new Calculadora();
            int resultadoEsperado = 6;

            // Act - Invocar al m�todo a probar
            int resultado = calculadora.AddConSaltoYVacio(numeros);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_ProbarNegativos()
        {
            // Arrange - Preparar el caso de prueba
            string numeros = "-50";
            Calculadora calculadora = new Calculadora();

            // Act - Invocar al m�todo a probar
            int resultado = calculadora.AddNegativo(numeros);

            //Assert
            //Se espera que lance la excepci�n: NegativoNoPermitidoException


        }
    }
}
