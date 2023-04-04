

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string respuesta, Recibo_de_sueldo, nombre;
            int? valor_hora, antiguedad, horas_laborales, sueldo;
            double? descuento, sueldos_totales=0, neto;

            Console.WriteLine("Nombre del empleado");
            nombre = Console.ReadLine();    
            Console.WriteLine("Pago por hora");
            valor_hora = int.Parse(Console.ReadLine());         
            Console.WriteLine("Antiguedad del empleado");
            antiguedad = int.Parse(Console.ReadLine());   
            Console.WriteLine("Horas mensuales trabajadas");
            horas_laborales = int.Parse(Console.ReadLine());
            sueldo = horas_laborales * valor_hora;
            neto = sueldo * 0.87;
            descuento = sueldo - neto;
            sueldos_totales += sueldo;
            Console.WriteLine("El empleado {0} tiene {1} años de antiguedad, se le paga por hora {2} y cobra {3} menos {4}", nombre, antiguedad, valor_hora, sueldo, descuento);
            Console.WriteLine("Desea ingresar los datos de otro empleado?");
            respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Nombre del empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Pago por hora");
                valor_hora = int.Parse(Console.ReadLine());
                Console.WriteLine("Antiguedad del empleado");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Horas mensuales trabajadas");
                horas_laborales = int.Parse(Console.ReadLine());
                sueldo = horas_laborales * valor_hora;
                descuento = sueldo * 0.87;
                sueldos_totales += sueldo;
                horas_laborales = int.Parse(Console.ReadLine());
                sueldo = horas_laborales * valor_hora;
                neto = sueldo * 0.13;
                descuento = sueldo - neto;
                sueldos_totales += sueldo;
                
                Console.WriteLine("El empleado {0} tiene {1} años de antiguedad, se le paga por hora {2} y cobra {3} menos {4}", nombre, antiguedad, valor_hora, sueldo, descuento);
                Console.WriteLine("Desea ingresar los datos de otro empleado?");
                respuesta = Console.ReadLine();
            }
           
         
        }
    }
}