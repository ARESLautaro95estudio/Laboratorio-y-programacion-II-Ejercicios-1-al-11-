using System.ComponentModel.DataAnnotations;

namespace Clase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre_mascota;
            int edad_mascota = 0;
            string tipo_mascota;
            int peso = 0;
            string diagnostico;

            //NOMBRE
            Console.WriteLine("¿Como se llama su mascota?");
            nombre_mascota = Console.ReadLine();
            //Edad
            Console.WriteLine("¿cuantos años tiene {0} ?", nombre_mascota);
            int.TryParse(Console.ReadLine(), out edad_mascota);
            while (edad_mascota < 1 || edad_mascota > 12)
            {
                Console.WriteLine("Error edad invalida");
                Console.WriteLine("¿cuantos años tiene {0} ?", nombre_mascota);
                int.TryParse(Console.ReadLine(), out edad_mascota);

            }
            //PESO
            Console.WriteLine("Cuanto pesa {0}?", nombre_mascota);
            int.TryParse(Console.ReadLine(), out peso);
            while (peso < 0 || peso > 50)
            {
                Console.WriteLine("Error peso invalido");
                Console.WriteLine("Cuanto pesa {0}?", nombre_mascota);
                int.TryParse(Console.ReadLine(), out peso);
            }
            //ESPECIE
            Console.WriteLine("¿Que especie es {0}?", nombre_mascota);
            tipo_mascota = Console.ReadLine();
            while (tipo_mascota != "gato" && tipo_mascota != "perro" && tipo_mascota != "hamster")
            {
                Console.WriteLine("Dato invalido");
                Console.WriteLine("¿Que especie es {0}?", nombre_mascota);
                tipo_mascota = Console.ReadLine();
            }
            //DIAGNOSTICO
            Console.WriteLine("Cual es el diagnostico?");
            diagnostico = Console.ReadLine();
            while (diagnostico != "otitis" && diagnostico != "alergias" && diagnostico != "parasitos")
            {
                Console.WriteLine("Error de diagnostico");
                Console.WriteLine("Cual es el diagnostico?");
                diagnostico = Console.ReadLine();
            }

            //Nombre de la mascota
            //Edad(Validar 1 - 12)
            //Tipo: (Validar “gato”, “perro”, “hamster”)
            //Peso: (Validar 0 - 50)
            //Diagnostico: (Validar  “otitis”, “alergias”, “parasitos”,)

            //Informes:

            //Nombre de la mascota más vieja
            //Cantidad de mascotas con parásitos
            //Nombre, edad y diagnóstico de la mascota más joven ingresada.
        }
    }
}