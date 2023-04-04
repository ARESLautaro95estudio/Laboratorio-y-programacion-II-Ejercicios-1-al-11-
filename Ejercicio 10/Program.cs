namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_ingresado; string piramide = "*"; string espacios = "";
            int cantidad_espacios;

            Console.WriteLine("ingrese el ancho de la piramide:");
            numero_ingresado = int.Parse(Console.ReadLine());
            cantidad_espacios = numero_ingresado - 1;
            
            for (int i = 0; i <= numero_ingresado; i++)
            {
                //Console.WriteLine("{0} {1}", espacios, piramide);
                for (int j = 0; j <= cantidad_espacios; j++)
                {
                    espacios += " ";              
                }
                Console.WriteLine("{0}", espacios+ piramide);
                piramide += "**";
                espacios = "";
                cantidad_espacios--;        
            }
        }
    }
}