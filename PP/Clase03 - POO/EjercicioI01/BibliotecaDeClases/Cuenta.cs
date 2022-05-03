//Ejercicio I01 - Creo que necesito un préstamo

//Crear una aplicación de consola y una biblioteca de clases 
//que contenga la clase Cuenta.

//Deberá tener los atributos:

//titular que contendrá la razón social del titular de la cuenta.
//cantidad que será un número decimal que representa al 
//monto actual de dinero en la cuenta.
//Construir los siguientes métodos para la clase:

//Un constructor que permita inicializar todos los atributos.
//Un método getter para cada atributo.
//mostrar retornará una cadena de texto con todos los datos de la cuenta.
//ingresar recibirá un monto para acreditar a la cuenta. 
//Si el monto ingresado es negativo, no se hará nada.
//retirar recibirá un monto para debitar de la cuenta. 
//La cuenta puede quedar en negativo.
//En el método Main, simular depósitos y extracciones de dinero de la cuenta,
//e ir mostrando como va variando el saldo.

using System.Text;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        //Atributos
        private string razonSocial;
        private decimal cantidad;

        //Constructor
        public Cuenta(string titular, decimal cantidad)
        {
            this.razonSocial = titular;
            this.cantidad = cantidad;
        }

        //Getters
        public string GetRazonSocial()
        {
            return razonSocial;
        }

        public decimal GetCantidad()
        {
             return cantidad;
        }

        //Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {GetRazonSocial()}, Monto: {GetCantidad()}");

            return sb.ToString();

        }

        public void Ingresar(decimal montoAcreditar)
        {
            if (montoAcreditar > 0)
            {
                cantidad += montoAcreditar;
            }
        }

        
        public void Retirar (decimal montoRetirar)
        {
            cantidad -= montoRetirar;
        }


    }
}
