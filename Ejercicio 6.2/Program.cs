using System.Runtime.Intrinsics.X86;

namespace Ejercicio_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primer_año; int segundo_año;
            Console.WriteLine("ingrese un año ");
            primer_año = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro año");
            segundo_año = int.Parse(Console.ReadLine());

            for (int i = primer_año+1; i < segundo_año; i++)
            {
                if (i%4 ==0 || i%400 ==0)
                {
                    Console.WriteLine(i);
                }
            }
            //Escribir un programa que determine si un año es bisiesto.
            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo
            //si ellos
            //también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en
            //ese rango.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).
        }
    }
}