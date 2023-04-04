using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año_ingresado; int mes_ingresado; int dia_ingresado; 

            Console.WriteLine("Ingrese el año de su nacimiento");
            año_ingresado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el mes de su nacimiento");
            mes_ingresado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el dia de su nacimiento");
            dia_ingresado=int.Parse(Console.ReadLine());

            DateTime date = new DateTime(año_ingresado,mes_ingresado,dia_ingresado);
            DateTime fecha = DateTime.Now;

            //Console.WriteLine(fecha.Subtract(date));
            TimeSpan dias_totales = fecha.Subtract(date);
            Console.WriteLine(dias_totales.Days);



            //Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes
            //y año) y
            //calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha
            //del sistema con DateTime.Now).
            //Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.

        }
    }
}