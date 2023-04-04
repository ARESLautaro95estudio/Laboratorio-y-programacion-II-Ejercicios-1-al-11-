namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            //(excluido el mismo) que son divisores del número.
            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            //Nota: Utilizar estructuras repetitivas y selectivas.
            double numEncontrados; numEncontrados = 0;
            int contador; contador = 1;
            double numero5; double numero2; double numero3; double numero4;
            numero5 =0;numero2 = 0; numero3 = 0;    numero4 = 0;
            double ecua1; ecua1 = 0;
            double ecua2; ecua2 = 0;
            double formula;formula = 0;

            numero2 = Math.Pow(2, 2 - 1) * (Math.Pow(2, 2) - 1);
            numero3 = Math.Pow(2, 3 - 1) * (Math.Pow(2, 3) - 1);
            numero4 = Math.Pow(2, 4 - 1) * (Math.Pow(2, 4) - 1);
            numero5 = Math.Pow(2, 5 - 1) * (Math.Pow(2, 4) - 1);
            Console.Write(numero2);
            Console.WriteLine( " ");
            Console.Write(numero3);
            Console.WriteLine(" ");
            Console.Write(numero4);
            Console.WriteLine(" ");
            Console.Write(numero5);

        }
    }
}