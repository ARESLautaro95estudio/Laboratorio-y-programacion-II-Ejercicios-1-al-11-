namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_ingresado; string escalon = "*";

            Console.WriteLine("ingrese una altura de escalon");
            numero_ingresado = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero_ingresado; i++)
            {
                Console.WriteLine(escalon);
                escalon += "**";
            }
        }
    }
}