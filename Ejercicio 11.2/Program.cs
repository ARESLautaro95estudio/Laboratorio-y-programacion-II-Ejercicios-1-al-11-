using Ejercicio_11;

namespace Ejercicio_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valores=0,min =1000,max =-100000,promedio; string val;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Ingrese un numero");
                valores = int.Parse(Console.ReadLine());    
                while (!Ejercicio_11.Validación.validar(valores, -100, 100))
                {
                    Console.WriteLine("Ingrese un numero");
                    val = Console.ReadLine();
                    valores = Convert.ToInt32(val);

                    # int.TryParse(Console.ReadLine(),out valores);

                    if ((Ejercicio_11.Validación.validar(valores, -100, 100) == true))
                    {
                        if (valores < min)
                        {
                            min = valores;
                        }
                        if (valores > max)
                        { max = valores; }
                    }
                }
                valores =valores+ valores;
            }
            promedio = valores / 10;
            Console.WriteLine("El maximo es {0} el minimo {1} y el promedio es {2}",max,min,promedio);
            //11.
            //Realizar una clase llamada Validación que posea
            //un método estático llamado Validar, que posea la
            //siguiente firma: bool Validar(int valor, int min, int max):

            //a.valor: dato a validar
            //b.min y max: rango en el cual deberá estar la variable valor.

            //Pedir al usuario que ingrese 10 números enteros. Validar con
            //el método desarrollado
            //anteriormente que estén dentro del rango -100 y 100.
            //Terminado el ingreso mostrar el valor mínimo, el valor máximo
            //y el promedio.
            //Nota: Utilizar variables escalares, NO utilizar vectores.
        }
    }
}