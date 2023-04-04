using System.Runtime.ConstrainedExecution;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double numero2;
            double numero3;

            //Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
            //mayor que cero, caso contrario, mostrar el mensaje: &quot; ERROR. ¡Reingresar número!&quot;.
            //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
            Console.WriteLine("ingrese un numero");
            numero = double.Parse(Console.ReadLine());
            while (numero < 0)
            {
                Console.WriteLine("ingrese un numero");
                numero = double.Parse(Console.ReadLine());
            }

            numero2 = Math.Pow(numero, 2);
            numero3 = Math.Pow(numero, 3);
            Console.WriteLine("El numero al cuadrado es {0} y el numero al cubo es {1}",numero2,numero3);



        }
    }
}