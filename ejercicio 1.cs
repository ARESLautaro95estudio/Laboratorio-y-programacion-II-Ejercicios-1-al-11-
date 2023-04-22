using System.Xml;

namespace ConsoleApp1
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int i=0,numero=0,max=0,min=0;        
            Single acumulador=0,promedio=0;
           
            while (i < 5)
            {
                i++;                 
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                acumulador += numero;

                if (i == 1)
                    min = numero;
                if (min > numero)
                    min = numero;
                if (max < numero)
                    max = numero;
            }
            promedio = acumulador / 5;
            Console.WriteLine("El numero mayor es {0} el menor es {1} y el promedio es {2}", max, min, promedio);
        }    
    }   
}    