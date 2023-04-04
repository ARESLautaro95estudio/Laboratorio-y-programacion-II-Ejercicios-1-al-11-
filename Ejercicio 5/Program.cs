using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador_izq=0; int contador_der = 0;int numero = 1;
            int ipot; int numero_ingresado;

            Console.WriteLine("Escriba un numero mayor a 1");
            numero_ingresado = int.Parse(Console.ReadLine());

            while (numero_ingresado > numero)
            {
                for (int i = 1; i < numero; i++)
                {
                    contador_izq+=i;
                }
                ipot = numero + 1;
                while (contador_der < contador_izq)
                {
                    contador_der += ipot;
                    ipot++;
                }
                if (contador_der == contador_izq)
                {
                    Console.WriteLine(numero);
                    //Console.WriteLine(contador_izq);
                }
                numero++;
                contador_izq = 0;
                contador_der = 0;
            }
            //int grupo_1; int grupo_2; int numero_ingresado; int contador; 
            //grupo_1 = 1;grupo_2 = 0;
            //Console.WriteLine("Escriba un numero mayor a 1");
            //numero_ingresado = int.Parse(Console.ReadLine());

            //while (numero_ingresado < 0)
            //{
            //    Console.WriteLine("Error! Ingrese un numero valido");
            //    Console.WriteLine("Escriba un numero mayor a 1");
            //    numero_ingresado = int.Parse(Console.ReadLine());
            //}
            //contador = numero_ingresado;
            //for (int i = 1; i < numero_ingresado; i++)
            //{
            //    grupo_1=grupo_1+1;                                               
            //}

            //while (grupo_1 != grupo_2)
            //{
            //    grupo_2 = contador + (contador - 1);
            //    if (grupo_1 == grupo_2)
            //    {
            //        Console.WriteLine("Los grupos son {0} {1} ", grupo_1, grupo_2);
            //    }
            //}


            //Un centro numérico es un número que separa una lista de
            //números enteros(comenzando en 1) en
            //dos grupos de números, cuyas sumas son iguales.
            //El primer centro numérico es el 6, el cual separa la
            //lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
            //cuyas sumas son ambas iguales a 15.
            //El segundo centronumérico es el 35, el cual separa la
            //lista(1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas
            //sumas son ambas iguales a 595.
            //Se pide elaborar una aplicación que calcule los centros
            //numéricos entre 1 y el número que el
            //usuario ingrese por consola.
            //Nota: Utilizar estructuras repetitivas y selectivas.

        }
    }
}