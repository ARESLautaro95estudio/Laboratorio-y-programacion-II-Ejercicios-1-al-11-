using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Ejercicio_11

{
    public class Validación
    {
       
        public static bool validar (int valor, int minimo, int maximo)
        { 
           return (valor >= minimo && valor <= maximo);
        }
       

    }
}