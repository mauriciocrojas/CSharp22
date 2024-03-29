﻿//Ejercicio I07 - Recibo de sueldo

//Se debe pedir el ingreso por teclado del valor hora, el nombre,
//la antigüedad (en años) y la cantidad de horas trabajadas 
//en el mes de N cantidad de empleados de una fábrica.

//Se pide calcular el importe a cobrar teniendo en cuenta que 
//el total (que resulta de multiplicar el valor hora por la cantidad 
//de horas trabajadas), hay que sumarle la cantidad de años trabajados 
//multiplicados por $150, y al total de todas esas operaciones restarle 
//el 13% en concepto de descuentos.

//Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor 
//hora, el total a cobrar en bruto y el total a cobrar neto de todos 
//los empleados ingresados.

//Utilizar sentencias de iteración y selectivas.
//No es necesario ni se deben utilizar vectores/arrays.


using System;

namespace EjercicioI07
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Se debe pedir el ingreso por teclado del valor hora, el nombre,
            //la antigüedad (en años) y la cantidad de horas trabajadas 
            //en el mes de N cantidad de empleados de una fábrica.

            string name;
            int hourPrice;
            int hoursWorked;
            int laborOld;


            Console.WriteLine("Enter employee name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter price hour: ");
            int.TryParse(Console.ReadLine(), out hourPrice);

            Console.WriteLine("Enter hours worked in month: ");
            int.TryParse(Console.ReadLine(), out hoursWorked);

            Console.WriteLine("Enter labor old (years): ");
            int.TryParse(Console.ReadLine(), out laborOld);

            //Se pide calcular el importe a cobrar teniendo en cuenta que 
            //el total (que resulta de multiplicar el valor hora por la cantidad 
            //de horas trabajadas), hay que sumarle la cantidad de años trabajados 
            //multiplicados por $150, y al total de todas esas operaciones restarle 
            //el 13% en concepto de descuentos.

            int grossPrice = (hoursWorked * hourPrice + (laborOld * 150));
            double netPrice = grossPrice - (grossPrice * 0.13);

            //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor 
            //hora, el total a cobrar en bruto y el total a cobrar neto de todos 
            //los empleados ingresados

            Console.WriteLine($"\nName: {name}\nLabor Old: {laborOld}\nHour Price: {hourPrice}\n" +
                        $"Gross Price: {grossPrice}\nNet Price: {netPrice}");

        }
    }
}
